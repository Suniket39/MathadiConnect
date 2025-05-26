using MathadiConnect.Infrastructure.Entities.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MathadiConnect.Infrastructure.EntityConfigurations.UserManagement
{
    public class RoleMasterConfiguration : IEntityTypeConfiguration<RoleMaster>
    {
        public void Configure(EntityTypeBuilder<RoleMaster> builder)
        {
            builder.HasKey(x => x.RoleId);
            builder.Property(x => x.RoleId).ValueGeneratedOnAdd();
            builder.Property(x => x.RoleName).IsRequired(true).HasMaxLength(30);
            builder.Property(x => x.IsActive).HasDefaultValue(true);
        }
    }
}
