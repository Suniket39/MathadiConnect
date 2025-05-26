using MathadiConnect.Infrastructure.Entities.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathadiConnect.Infrastructure.EntityConfigurations.UserManagement
{
    public class UserManagerConfiguration : IEntityTypeConfiguration<UserManager>
    {
        public void Configure(EntityTypeBuilder<UserManager> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.UserName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.LastName).IsRequired().HasMaxLength(50);
            builder.Property(u => u.Email).IsRequired().HasMaxLength(100);
            builder.Property(u => u.MobileNumber).HasMaxLength(15);
            builder.Property(u => u.PasswordHash).IsRequired();
            //builder.Property(u => u.CreatedBy).HasMaxLength(50);
            //builder.Property(u => u.ModifiedBy).HasMaxLength(50);

            builder.HasOne(u => u.RoleMaster).WithMany().HasForeignKey(u => u.RoleId).OnDelete(DeleteBehavior.Restrict);
            CommonEntityConfiguration.Configure(builder);
            // Define table name
            builder.ToTable("UserManagers");
        }
    }
}
