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
	public class AboutManager : GenericManager<About>, IAboutService
	{
		public AboutManager(IGenericDal<About> genericDal) : base(genericDal)
		{

		}
	}
}
