﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.DefaultLayout
{
    public class _DefaultFactComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();

        }
    }
}
