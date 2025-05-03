using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using Cental.DataAccesLayer.Repostories;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Concreate
{
    public class EfReviewDal : GenericRepostory<Review>, IReviewDal
    {
        public EfReviewDal(CentalContext context) : base(context)
        {
        }
    }
}
