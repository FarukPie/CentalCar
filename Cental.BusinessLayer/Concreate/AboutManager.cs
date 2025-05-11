using Cental.BusinessLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Repostories;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
	public class AboutManager : IAboutService
	{
		private readonly IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

		public void TCreate(About entitiy)
		{
			_aboutDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_aboutDal.Delete(id);
		}

		public List<About> TGetAll()
		{
			return _aboutDal.GetAll();	
		}

		public About TGetById(int id)
		{
			return _aboutDal.GetById(id);
		}

		public void TUpdate(About entitiy)
		{
			_aboutDal.Update(entitiy);
		}
	}
}
