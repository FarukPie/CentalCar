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
	public class BannerManager : IBannerService
	{
		private readonly IBannerDal _bannerDal;

		public BannerManager(IBannerDal bannerDal)
		{
			_bannerDal = bannerDal;
		}

		public void TCreate(Banner entitiy)
		{
			_bannerDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_bannerDal.Delete(id);
		}

		public List<Banner> TGetAll()
		{
			return _bannerDal.GetAll();
		}

		public Banner TGetById(int id)
		{
			return _bannerDal.GetById(id);
		}

		public void TUpdate(Banner entitiy)
		{
			_bannerDal.Update(entitiy);
		}
	}
}
