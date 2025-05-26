using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathadiConnect.Infrastructure.Entities.UserManagement
{
    public class UserScreenMaster
    {
        public UserScreenMaster()
        {
            UserAccessManagers = new List<UserAccessManager>();
        }

        public int UserScreenId { get; set; }
        public string MenuName { get; set; } 
        public string ScreenName { get; set; }
        public string ScreenCode { get; set; }
        public int ParentId { get; set; }
        public string RoutingURL { get; set; }
        public string MenuIcon { get; set; }
        public bool IsActive { get; set; }
        public virtual ICollection<UserAccessManager> UserAccessManagers { get; set; }
    }
}
