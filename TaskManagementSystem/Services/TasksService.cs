using Microsoft.EntityFrameworkCore;
using TaskManagementSystem.Helper;
using TaskManagementSystem.Models;
using TaskManagementSystem.Repository;

namespace TaskManagementSystem.Services
{
    public class TasksService
    {
        IRepository<TaskItem> _taskRepo;
        public TasksService(IRepository<TaskItem> taskService)
        {
            _taskRepo = taskService;
        }

        public List<TaskItem> GetAll()
        {
            return _taskRepo.GetAll().Where(t=>t.UserId==UserSession.ID)
                            .Include(x=>x.Category).Include(x=>x.User)
                            .ToList();
        }

        public async Task<TaskItem> GetByID(int id)
        {
            return await _taskRepo.GetByIDAsync(id);
        }

        public async Task DeleteAsync(int id)
        {
            var isTaskExist = await _taskRepo.IsExistAsync(id);
            if (isTaskExist)
            {
                _taskRepo.Delete(new TaskItem() { ID = id});
            }
        }

        public void Update(TaskItem taskItem)
        {
            var task = _taskRepo.GetAll(x => x.ID == taskItem.ID).FirstOrDefault();
            task.Title = taskItem.Title;
            task.Description = taskItem.Description;
            task.CategoryID = taskItem.CategoryID;
            task.Status = taskItem.Status;
            task.Priority = taskItem.Priority;
            task.DueDate = taskItem.DueDate;
            _taskRepo.SaveChanges();
        }

        public async Task AddAsync(TaskItem taskItem)
        {
            taskItem.UserId = UserSession.ID;
            await _taskRepo.AddAsync(taskItem);
            _taskRepo.SaveChanges();
        }

        
    }
}
