using Cental.DataAccesLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
	public class ServiceManager : IServiceDal
	{
		private readonly IServiceDal _serviceDal;

		public ServiceManager(IServiceDal serviceDal)
		{
			_serviceDal = serviceDal;
		}

		public void Create(Service entitiy)
		{
			_serviceDal.Create(entitiy);
			
		}

		public void Delete(int id)
		{
			_serviceDal.Delete(id);
		}

		public List<Service> GetAll()
		{
			return _serviceDal.GetAll();
		}

		public Service GetById(int id)
		{
			return _serviceDal.GetById(id);
		}

		public void Update(Service entitiy)
		{
			_serviceDal.Update(entitiy);
		}
	}
}
