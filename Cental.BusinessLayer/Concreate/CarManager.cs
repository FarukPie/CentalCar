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
	public class CarManager : ICarService
	{
		private readonly ICarDal _carDal;

		public CarManager(ICarDal carDal)
		{
			_carDal = carDal;
		}

		public void TCreate(Car entitiy)
		{
			_carDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_carDal.Delete(id);
		}

		public List<Car> TGetAll()
		{
			return _carDal.GetAll();
		}

		public Car TGetById(int id)
		{
			return _carDal.GetById(id);
		}

		public void TUpdate(Car entitiy)
		{
			_carDal.Update(entitiy);
		}
	}
}
