using Microsoft.AspNetCore.Mvc;

namespace laba_8_MVC.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
