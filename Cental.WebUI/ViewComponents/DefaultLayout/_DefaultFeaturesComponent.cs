using AutoMapper;
using Cental.BusinessLayer.Abstract;
using Cental.DtoLayer.FeatureDtos;
using Microsoft.AspNetCore.Mvc;

namespace Cental.WebUI.ViewComponents.DefaultLayout
{
    public class _DefaultFeaturesComponent: ViewComponent
    {
      private readonly IFeaturesService _featuresService;
        private readonly IMapper _mapper;

		public _DefaultFeaturesComponent(IFeaturesService featuresService, IMapper mapper)
		{
			_featuresService = featuresService;
			_mapper = mapper;
		}

		public IViewComponentResult Invoke()
        {
            var value = _featuresService.TGetAll();
            var features=_mapper.Map<List<ResultListFeatureDto>>(value);
            return View(features);
        }
    }
}
