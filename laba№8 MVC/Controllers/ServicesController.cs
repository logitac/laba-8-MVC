using Microsoft.AspNetCore.Mvc;

namespace laba_8_MVC.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
