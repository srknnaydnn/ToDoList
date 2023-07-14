using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TodoList.Model.Configuration
{
    public class TodoItemConfiguration : IEntityTypeConfiguration<TodoItem>
    {
        public void Configure(EntityTypeBuilder<TodoItem> builder)
        {

            builder.HasKey(x => x.Id);

            builder.HasOne<User>(s => s.User)
                .WithMany(x => x.TodoItems)
                .HasForeignKey(x => x.UserId);
        }
    }
}
