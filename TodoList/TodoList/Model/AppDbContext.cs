using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TodoList.Model.Seed;

namespace TodoList.Model
{
    public class AppDbContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-08U3B1T;Initial Catalog=Todo;User ID=sa;Password=P0rtakal; Encrypt=True;TrustServerCertificate=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            DataSeed.UserSedd(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
       
      
        public DbSet<User> Users { get; set; }
        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
