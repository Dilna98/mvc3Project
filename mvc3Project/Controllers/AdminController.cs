using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc3Project.DATA;
using System.Threading.Tasks;

namespace mvc3Project.Controllers
{
   
    public class AdminController : Controller
    {
        private readonly ApplicationDBContext _context;
        public AdminController(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> AdminIndex()
        {
            var register = await _context.Register.ToListAsync();
            return View(register);
        }
        //public IActionResult AdminIndex()
        //{
        //    return View();
        //}
        public IActionResult logout()
        {
            return new RedirectResult(url: "Login/Login", permanent: true, preserveMethod: true);
        }
        public async Task<IActionResult> ViewRegistration()
        {
            var data = _context.Register.ToList();

           return View(data);
        }
        public async Task<IActionResult> Approve(int id)
        {
            var data = await _context.Register.FindAsync(id);
            if (data == null)
            {
                return NotFound();
            }
            data.Status = " Approved";
            await _context.SaveChangesAsync();
            return RedirectToAction("AdminIndex");
        }
    }
}
