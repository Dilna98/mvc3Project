using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mvc3Project.DATA;
using mvc3Project.Models;

namespace mvc3Project.Controllers
{
    public class RegisterController : Controller
    {
        private readonly ApplicationDBContext _context;
        public RegisterController(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var register = await _context.Register.ToListAsync();
            return View(register);
        }

        [HttpPost]
        public IActionResult Create(Register rg)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rg);
                _context.SaveChanges();
                return RedirectToAction(nameof(Login));
            }
            return View();

        }

        public IActionResult Create()
        {

            return View();
        }
        public IActionResult Login()
        {
            return View();
        }


        public IActionResult Log(Login r)
        {
            var type = "";
            var filterd = from l in _context.Register where l.Email == r.Email && l.Password == r.Password  && l.Status == "Approved" select l;
            foreach (var p in filterd)
            {
                type = p.Type;
                if (type == "staff")
                {
                    return new RedirectResult(url: "/Staff/StaffIndex", permanent: true, preserveMethod: true);
                }
                if (type == "admin")
                {
                    return new RedirectResult(url: "/Admin/AdminIndex", permanent: true, preserveMethod: true);
                }
            }

            TempData["Message"] = "invalid username and password";
            return Ok();
        }
        
    }
}