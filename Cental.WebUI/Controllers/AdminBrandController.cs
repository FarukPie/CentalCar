using Cental.BusinessLayer.Abstract;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
	public class AdminBrandController(IBrandService _brandservice) : Controller
	{
		public IActionResult Index()
		{
			var value = _brandservice.TGetAll();
			return View(value);
		}

		public IActionResult DeleteBrand(int id)
		{
			_brandservice.TDelete(id);
			return RedirectToAction("Index");
		}

		public IActionResult CreateBrand()
		{

			return View();

		}
		[HttpPost]
		public IActionResult CreateBrand(Brand model)
		{
			_brandservice.TCreate(model);
			return RedirectToAction("Index");

		}
	}
	}
