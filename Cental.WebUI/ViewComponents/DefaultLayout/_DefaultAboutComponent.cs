using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.AboutDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.DefaultLayout
{
    public class _DefaultAboutComponent : ViewComponent
    {
        private readonly IAboutService _aboutservice;
        private readonly IMapper _mapper;
        public _DefaultAboutComponent(IAboutService aboutservice, IMapper mapper)
        {
            _aboutservice = aboutservice;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var values = _aboutservice.TGetAll();
            var abouts=_mapper.Map<List<ResultListAboutDto>>(values);
            return View(abouts);
        }
    }
}
