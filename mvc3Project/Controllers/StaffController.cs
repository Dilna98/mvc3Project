using Microsoft.AspNetCore.Mvc;

namespace mvc3Project.Controllers
{
    public class StaffController : Controller
    {
        public IActionResult StaffIndex()
        {
            return View();
        }
        public IActionResult logout()
        {
            return new RedirectResult(url: "Login/Login", permanent: true, preserveMethod: true);
        }
        //public async Task<IActionResult>Profile()
        //{
        //    int? id = HttpContent.Session.GetInt32("id");
        //    var pro = await _context.Register.FirstOrDefaultAsync(c => c.Rid == id);

        //    if(pro == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(pro);
        //}
    }
}
