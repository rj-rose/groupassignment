using groupassignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace groupassignment.Controllers
{
    public class HomeController : Controller
    {
       
        private readonly OurDbContext _context;
        public HomeController(OurDbContext _context)
        {
            this._context = _context;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(AddUserAccountModel request)
        {
            var user = new UserAccount()
            {
                Userid = Guid.NewGuid(),
                Fname = request.Fname,
                Lname = request.Lname,
                Username = request.Username,
                Password = request.Password,
                Email = request.Email,

            };
            await _context.UserAccounts.AddAsync(user);
            await _context.SaveChangesAsync();
            return RedirectToAction("Login");

        }
    }
     
}