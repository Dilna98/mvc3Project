using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc3Project.DATA;
using mvc3Project.Models;

namespace mvc3Project.Controllers
{
    public class StaffController : Controller
    {
        private readonly ApplicationDBContext _context;
        public StaffController(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> StaffIndex()
        {
            var complaints = await _context.Complaints.ToListAsync();
            return View(complaints);
        }
        //public IActionResult StaffIndex()
        //{
        //    return View();
        //}
        public IActionResult logout()
        {
            return new RedirectResult(url: "Login/Login", permanent: true, preserveMethod: true);
        }
       

        public IActionResult Complaints()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Complaints(Complaints c)
        {
            Int32? id = HttpContext.Session.GetInt32("id");
            c.Rid = (int)id;
            c.Date = DateTime.Now;

            _context.Complaints.Add(c);
            _context.SaveChanges();

            return View();
        }
            
    }
}
