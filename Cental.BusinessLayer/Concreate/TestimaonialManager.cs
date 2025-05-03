using Cental.DataAccesLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
    public class TestimaonialManager : GenericManager<Testimonial>
    {
        public TestimaonialManager(IGenericDal<Testimonial> genericDal) : base(genericDal)
        {
        }
    }
}
