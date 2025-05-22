using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminMessage : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
