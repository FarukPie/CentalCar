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
	public class TestimaonialManager : ITestimonialService
	{
		private readonly ITestimonialsDal _testimonialDal;

		public TestimaonialManager(ITestimonialsDal testimonialDal)
		{
			_testimonialDal = testimonialDal;
		}

		public void TCreate(Testimonial entitiy)
		{
			_testimonialDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_testimonialDal.Delete(id);
		}

		public List<Testimonial> TGetAll()
		{
			return _testimonialDal.GetAll();
		}

		public Testimonial TGetById(int id)
		{
			return _testimonialDal.GetById(id);
		}

		public void TUpdate(Testimonial entitiy)
		{
			_testimonialDal.Update(entitiy);	
		}
	}
}
