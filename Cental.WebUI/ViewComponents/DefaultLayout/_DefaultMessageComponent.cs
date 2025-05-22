using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.DefaultLayout
{
    public class _DefaultMessageComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }

      

    }
}
