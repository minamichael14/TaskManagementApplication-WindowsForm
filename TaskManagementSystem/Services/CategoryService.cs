using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repository;

namespace TaskManagementSystem.Services
{
    public class CategoryService
    {
        IRepository<Category> _categoryRepo;
        public CategoryService(IRepository<Category> categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        public IQueryable<Category> GetAll()
        {
            return _categoryRepo.GetAll();
        }

        public async Task AddAsync(Category category)
        {
            await _categoryRepo.AddAsync(category);
            _categoryRepo.SaveChanges();
        }
    }
}
