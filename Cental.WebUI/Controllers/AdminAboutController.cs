using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Cental.EntityLayer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.Controllers
{
    public class AdminAboutController : Controller
    {
        private readonly IAboutService _aboutService;

        public AdminAboutController(IAboutService aboutService)
        {
            _aboutService = aboutService;
        }

        public IActionResult Index()
        {
            var values = _aboutService.TGetAll();
            var result =values.Select(about => new ResultAboutDto
            {
                AboutId=about.AboutId,
                Mission=about.Mission,
                Vision=about.Vision,
            }).ToList();
            return View(result);
        }

        [HttpGet]
        public IActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto model)
        {
            //manuel olarak nesneden nesneye mapping yaptık burda
            _aboutService.TCreate(new About
            {
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                item1 = model.item1,
                item2 = model.item2,
                item3 = model.item3,
                item4 = model.item3,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicUrl = model.ProfilePicUrl,
                StartYear = (int)model.StartYear,
                Vision = model.Vision
            });
            return RedirectToAction("Index");
        }


        public IActionResult DeleteAbout(int id) { 

        _aboutService.TDelete(id);
        return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var model = _aboutService.TGetById(id);
            var about = new UpdateAboutDto
            {
                AboutId = model.AboutId,
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                item1 = model.item1,
                item2 = model.item2,
                item3 = model.item3,
                item4 = model.item3,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicUrl = model.ProfilePicUrl,
                StartYear = (int)model.StartYear,
                Vision = model.Vision

            };



            return View(about);
        }
        [HttpPost]
        public IActionResult UpdateAbout(UpdateAboutDto model)
        {
            var about = new About
            {   
                AboutId = model.AboutId,
                Description1 = model.Description1,
                Description2 = model.Description2,
                ImageUrl1 = model.ImageUrl1,
                ImageUrl2 = model.ImageUrl2,
                item1 = model.item1,
                item2 = model.item2,
                item3 = model.item3,
                item4 = model.item3,
                JobTitle = model.JobTitle,
                Mission = model.Mission,
                NameSurname = model.NameSurname,
                ProfilePicUrl = model.ProfilePicUrl,
                StartYear = (int)model.StartYear,
                Vision = model.Vision

            };
            _aboutService.TUpdate(about);
            return RedirectToAction("Index");

        }

    }
}
