using Microsoft.AspNetCore.Mvc;

namespace mvc3Project.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
    }
}
