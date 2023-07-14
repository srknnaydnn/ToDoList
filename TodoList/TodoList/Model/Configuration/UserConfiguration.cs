using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TodoList.Model.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(t => t.Surname)
                .IsRequired()
                .HasMaxLength (50);

            builder.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            builder.HasIndex(t => t.Email)
                .IsUnique();


        }
    }
}
