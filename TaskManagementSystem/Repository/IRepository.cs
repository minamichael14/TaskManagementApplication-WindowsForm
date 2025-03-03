using System.Linq.Expressions;
using TaskManagementSystem.Models;

namespace TaskManagementSystem.Repository
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {
        // Retriving 
        IQueryable<TEntity> GetAll();
        IQueryable<TEntity> GetAll(Expression<Func<TEntity, bool>> expression);
        Task<TEntity> GetByIDAsync(int id);

        // Add
        Task AddAsync(TEntity entity);
        Task AddRangeAsync(IEnumerable<TEntity> entities);


        // Update 
        void Update(TEntity entity);

        void SaveInclude(TEntity entity, params string[] properties);

        //Delete
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

        // IsExist
        Task<bool> IsExistAsync(int id);

        // SaveChanges
        void SaveChanges();
    }
}
