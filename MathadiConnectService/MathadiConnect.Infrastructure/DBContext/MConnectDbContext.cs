

using MathadiConnect.Infrastructure.Entities.UserManagement;
using MathadiConnect.Infrastructure.EntityConfigurations.UserManagement;
using Microsoft.EntityFrameworkCore;

namespace MathadiConnect.Infrastructure.DBContext
{
    public class MConnectDbContext : DbContext
    {
        public MConnectDbContext(DbContextOptions<MConnectDbContext> options) : base(options)
        {
        }
        public DbSet<UserManager> UserManager { get; set; }
        public DbSet<RoleMaster> RoleMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserManagerConfiguration());
            modelBuilder.ApplyConfiguration(new RoleMasterConfiguration());
        }
    }
}
