using AutoMapper;
using Cental.DtoLayer.FeatureDtos;
using Cental.EntityLayer.Entities;
namespace Cental.WebUI.Mappings
{
	public class FeatureMapping : Profile
	{

		public FeatureMapping() 
		{
			CreateMap<Feature, ResultListFeatureDto>().ReverseMap();

		}
	}
}
