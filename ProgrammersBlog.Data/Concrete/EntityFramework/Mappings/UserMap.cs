using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Concrete.EntityFramework.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.Email).IsRequired();
            builder.Property(u => u.Email).HasMaxLength(50);
            builder.HasIndex(u => u.Email).IsUnique();

            builder.Property(u => u.Username).IsRequired();
            builder.Property(u => u.Username).HasMaxLength(20); 
            builder.HasIndex(u => u.Username).IsUnique();

            builder.Property(u => u.PasswordHash).IsRequired();
            builder.Property(u => u.PasswordHash).HasColumnType("VARBINARY(500)");

            builder.Property(u => u.Description).HasMaxLength(500);

            builder.Property(u => u.FirstName).IsRequired();
            builder.Property(u => u.FirstName).HasMaxLength(30);
            
            builder.Property(u => u.LastName).IsRequired();
            builder.Property(u => u.LastName).HasMaxLength(30);

            builder.Property(u => u.Picture).IsRequired();
            builder.Property(u => u.Picture).HasMaxLength(250);

            builder.Property(u => u.CreatedByName).IsRequired();
            builder.Property(u => u.CreatedByName).HasMaxLength(50);

            builder.Property(u => u.ModifiedByName).IsRequired();
            builder.Property(u => u.ModifiedByName).HasMaxLength(50);

            builder.Property(u => u.CreatedTime).IsRequired();
            builder.Property(u => u.ModifiedDate).IsRequired();

            builder.Property(u => u.IsActive).IsRequired();
            builder.Property(u => u.IsDeleted).IsRequired();

            builder.Property(u => u.Note).HasMaxLength(500);

            builder.HasOne<Role>(u => u.Role).WithMany(r => r.Users).HasForeignKey(r => r.RoleId);

            builder.ToTable("Users");

            builder.HasData(new User
            {
                Id =1,
                RoleId =1,
                FirstName = "Harun",
                LastName = "Turkmenoglu",
                Email = "mht9811@gmail.com",
                IsActive = true,
                IsDeleted = false,
                CreatedByName = "Initial Create",
                CreatedTime = DateTime.Now,
                ModifiedByName = "Initial create",
                ModifiedDate = DateTime.Now,
                Description = "Ilk Admin Kullanici",
                Note = "Admin kullanicisi",
                PasswordHash =Encoding.ASCII.GetBytes("0192023a7bbd73250516f069df18b500"),
                Picture = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcSX4wVGjMQ37PaO4PdUVEAliSLi8-c2gJ1zvQ&usqp=CAU"
            });
        }
    }
}
