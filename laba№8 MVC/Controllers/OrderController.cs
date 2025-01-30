using laba_8_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace laba_8_MVC.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult check(Order order)
        {
            if (ModelState.IsValid)
            {
                return Redirect("/");
            }

            return View("Index");
        }
    }
}

