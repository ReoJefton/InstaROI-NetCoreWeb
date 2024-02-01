using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InstaRoi.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace InstaRoi.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {

        private ApplicationDbContext _application;
    public HomeController(ApplicationDbContext application)
        {
            _application = application;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult AdminView()
        {
            ViewData["Message"] = "Your application description page.";

            return View(_application.Users.ToList());
        }

        //public IActionResult AdminViewDelete()
        //{
        //    ViewData["Message"] = "Your application description page.";

        //    return View(_application.Users.ToList());
        //}

         public async Task<IActionResult> AdminViewDelete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var users = await _application.Users.FindAsync(id);
            if (users == null)
            {
                return NotFound();
            }

            return View(users);
        }

        // POST: Dashboard/Delete/5
        [HttpPost, ActionName("AdminViewDelete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var users = await _application.Users.FindAsync(id);
      //      await _application.Users.Remove(users);
      //transaction.Commit();
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public IActionResult Faq()
        {
            ViewData["Message"] = "Your FAQ page.";

            return View();
        }
        [AllowAnonymous]
        public IActionResult Start()
        {
            ViewData["Message"] = "Your Start page.";

            return View();
        }

        public IActionResult Chat()
        {
            ViewData["Message"] = "Your chat page.";

            return View();
        }
        [AllowAnonymous]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
