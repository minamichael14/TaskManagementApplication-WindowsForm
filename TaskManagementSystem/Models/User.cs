﻿namespace TaskManagementSystem.Models
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<TaskItem> TaskItems { get; set; }

    }
}
