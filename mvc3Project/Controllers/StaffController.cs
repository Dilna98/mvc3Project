using Microsoft.AspNetCore.Mvc;

namespace mvc3Project.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffIndex()
        {
            return View();
        }
    }
}
