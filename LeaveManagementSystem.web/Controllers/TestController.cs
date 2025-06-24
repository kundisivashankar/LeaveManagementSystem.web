using LeaveManagementSystem.web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var data = new TestViewModel
            {
                Name = "ChinnuuuuuuuuuuBBBBBBBBB",
                DateOfBirth = new DateTime(2002,06,05)
            };
            return View(data);
        }
    }
}
