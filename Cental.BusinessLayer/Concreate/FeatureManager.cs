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
	public class FeatureManager : IFeaturesService
	{
		private readonly IFeatureDal _featureDal;

		public FeatureManager(IFeatureDal featureDal)
		{
			_featureDal = featureDal;
		}

		public void TCreate(Feature entitiy)
		{
			_featureDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_featureDal.Delete(id);
		}

		public List<Feature> TGetAll()
		{
			return _featureDal.GetAll();
		}

		public Feature TGetById(int id)
		{
			return _featureDal.GetById(id);
		}

		public void TUpdate(Feature entitiy)
		{
			_featureDal.Update(entitiy);
		}
	}
}
