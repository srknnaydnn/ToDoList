using Microsoft.EntityFrameworkCore;

namespace TodoList.Model.Seed
{
    public static class DataSeed
    {
        public static void UserSedd(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(

                new User {Id=1,Name="Serkan",Surname="Aydın",Email="serkan@gmail.com",Password="serkan00!"}
                );

        }
    }
}
