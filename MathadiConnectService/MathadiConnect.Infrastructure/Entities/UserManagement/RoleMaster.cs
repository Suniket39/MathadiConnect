

namespace MathadiConnect.Infrastructure.Entities.UserManagement
{
    public class RoleMaster
    {
        public RoleMaster()
        {
            UserAccessManager = [];
            UserScreenMaster = [];
        }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<UserAccessManager> UserAccessManager { get; set; }
        public virtual ICollection<UserScreenMaster> UserScreenMaster { get; set; }
    }
}
