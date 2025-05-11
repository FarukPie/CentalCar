using Cental.BusinessLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
	public class BrandManager : IBrandService
	{
		private readonly IBrandDal _brandService;

		public BrandManager(IBrandDal brandService)
		{
			_brandService = brandService;
		}

		public void TCreate(Brand entitiy)
		{
			_brandService.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_brandService.Delete(id);
		}

		public List<Brand> TGetAll()
		{
			return _brandService.GetAll();
		}

		public Brand TGetById(int id)
		{
			return _brandService.GetById(id);
		}

		public void TUpdate(Brand entitiy)
		{
			_brandService.Update(entitiy);
		}
	}
}
