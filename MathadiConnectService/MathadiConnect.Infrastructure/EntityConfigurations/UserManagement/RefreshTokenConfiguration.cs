using MathadiConnect.Infrastructure.Entities.UserManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MathadiConnect.Infrastructure.EntityConfigurations.UserManagement
{
    public class RefreshTokenConfiguration : IEntityTypeConfiguration<RefreshToken>
    {
        public void Configure(EntityTypeBuilder<RefreshToken> builder)
        {
            builder.HasKey(rt => rt.Id);
            builder.Property(rt => rt.Id).ValueGeneratedOnAdd();
            builder.Property(rt => rt.Token).IsRequired().HasMaxLength(500);
            builder.Property(rt => rt.ExpiresOn).IsRequired();
            builder.Property(rt => rt.CreatedDate).IsRequired();
            builder.Property(rt => rt.CreatedByIp).HasMaxLength(45); // IPv6 support
            builder.Property(rt => rt.Revoked).HasMaxLength(500);
            builder.Property(rt => rt.RevokedByIp).HasMaxLength(45); // IPv6 support
        }
    }
}
