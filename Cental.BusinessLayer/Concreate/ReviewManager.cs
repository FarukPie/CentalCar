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
	public class ReviewManager : IReviewService
	{
		private readonly IReviewDal _reviewDal;

		public ReviewManager(IReviewDal reviewDal)
		{
			_reviewDal = reviewDal;
		}

		public void TCreate(Review entitiy)
		{
			_reviewDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_reviewDal.Delete(id);
		}

		public List<Review> TGetAll()
		{
			return _reviewDal.GetAll();	
		}

		public Review TGetById(int id)
		{
			return _reviewDal.GetById(id);
		}

		public void TUpdate(Review entitiy)
		{
			_reviewDal.Update(entitiy);
		}
	}
}
