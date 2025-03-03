﻿namespace TaskManagementSystem.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<TaskItem> TaskItems { get; set; }
    }
}
