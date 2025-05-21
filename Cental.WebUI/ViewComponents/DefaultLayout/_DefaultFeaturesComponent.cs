using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.DefaultLayout
{
    public class _DefaultFeaturesComponent: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
