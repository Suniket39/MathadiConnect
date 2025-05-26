using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MathadiConnect.Api.Controllers.UserManagement
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserManagementController : ControllerBase
    {
        public UserManagementController() { }
        public async Task<bool> GetAllUsers()
        {
            return true;
        }
    }
}
