using groupassignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace groupassignment.Controllers
{
    public class main : Controller
    {
        private readonly OurDbContext _Context;


        public main(OurDbContext dbContext)
        {
            _Context = dbContext;
        }

        // GET: HomeController1
        public ActionResult Index()
        {
            
            return View();
        }
        public IEnumerable<string> GetSessionInfo()
        {
            List<string> sessioninfo = new List<string>();
            if (string.IsNullOrWhiteSpace(HttpContext.Session.GetString(UserAccount.SessionKeyUsername)))
            {
                HttpContext.Session.SetString(UserAccount.SessionKeyUsername, "Current User");
                HttpContext.Session.SetString(UserAccount.SessionKeyId, "Current User");

            }
            var username = HttpContext.Session.GetString(UserAccount.SessionKeyUsername);
            var sessionId = HttpContext.Session.GetString(UserAccount.SessionKeyId);

            sessioninfo.Add(username);
            sessioninfo.Add(sessionId);

            return sessioninfo;

        }
        // GET: HomeController1/Details/5
        public ActionResult Details(int id)
        {
            var user = from b in _Context.UserAccounts select b;

            return View(user);
        }

        // GET: HomeController1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: HomeController1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
