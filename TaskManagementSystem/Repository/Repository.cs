using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly AppDBContext _appDbContext;
        private readonly DbSet<TEntity> _dbSet;
        public Repository(AppDBContext appDbContext)
        {
            _appDbContext = appDbContext;
            _dbSet = _appDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        

        public void Delete(TEntity entity)
        {
            var deletedEntity = _dbSet.Find(entity.ID);
            deletedEntity.IsDeleted = true;
            _appDbContext.SaveChanges();
        }

            
        public void DeleteRange(IEnumerable<TEntity> entities)
        {
            foreach (var Item in entities)
            {
                Delete(Item);
            }
        }

        public async Task<bool> IsExistAsync(int id)
        {
             return await _dbSet.AnyAsync(x => x.ID == id && !x.IsDeleted);
        }

        public IQueryable<TEntity> GetAll()
        {
            return _dbSet.Where(x=> !x.IsDeleted);
        }

        public IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression)
        {
            return GetAll().Where(expression);
        }

        public async Task<TEntity> GetByIDAsync(int id)
        {
            return await GetAll().Where(x => x.ID == id).FirstOrDefaultAsync();
        }

        public void SaveChanges()
        {
            _appDbContext.SaveChanges();
        }


        // update 

        public void Update(TEntity entity)
        {
            //_appDbContext.Attach(entity);
            _dbSet.Update(entity);
            //var updatedentity = _dbSet.FirstOrDefault(x => x.ID == entity.ID);
            //updatedentity = entity;
        }
        public void SaveInclude(TEntity entity, params string[] properties)
        {
            var local = _dbSet.Local.FirstOrDefault(x => x.ID == entity.ID);

            EntityEntry entityEntry = null;
            if (local is null)
            {
                entityEntry = _appDbContext.Entry(entity);
            }
            else
            {
                entityEntry = _appDbContext.ChangeTracker
                    .Entries<TEntity>().FirstOrDefault(x => x.Entity.ID == entity.ID);
            }

            foreach (var property in entityEntry.Properties)
            {
                if (properties.Contains(property.Metadata.Name))
                {
                    property.CurrentValue = entity.GetType().GetProperty(property.Metadata.Name).GetValue(entity);
                    property.IsModified = true;
                }
            }
        }

    }
}
