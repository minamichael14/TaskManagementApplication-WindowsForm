using Microsoft.EntityFrameworkCore;

namespace TaskManagementSystem.Models
{
    public class AppDBContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=.\\SQLExpress;Database=TaskManagementSystem;Trusted_Connection=True;Encrypt=False");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
