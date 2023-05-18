using Microsoft.AspNetCore.Mvc;
using On_DemandCarWash.Model;
using On_DemandCarWash.Services;
//using On_DemandCarWash.Services;
namespace On_DemandCarWash.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminService adminService;
        public AdminController(AdminService _adminService)
        {
            adminService = _adminService;
        }
        [HttpGet("GetAllAdmin")]
        public IActionResult GetAllAdmin()
        {
            return Ok(adminService.GetAllAdmin());
        }
        [HttpGet("GetAdmin")]
        public IActionResult GetAdmin(int id)
        {
            return Ok(adminService.GetAdmin(id));
        }
        [HttpPost("AddAdmin")]
        public IActionResult AddAdmin(Admin admin)
        {
            return Ok(adminService.AddAdmin(admin));
        }
        [HttpPut("UpdateAdmin")]
        public IActionResult UpdateAdmin(Admin admin)
        {
            return Ok(adminService.UpdateAdmin(admin));
        }
        [HttpDelete("DeleteAdmin")]
        public IActionResult DeleteAdmin(int id)
        {
            return Ok(adminService.DeleteAdmin(id));
        }
    }
}
