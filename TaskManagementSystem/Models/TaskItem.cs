using TaskManagementSystem.Models.Enums;

namespace TaskManagementSystem.Models
{
    public class TaskItem : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public TaskPriority Priority { get; set; } // Low, Medium, High
        public TaskStatusValue Status { get; set; } // Pending, In Progress, Completed

        public int UserId { get; set; }
        public User User { get; set; }


        public int CategoryID { get; set; }
        public Category Category { get; set; }


    }
}
