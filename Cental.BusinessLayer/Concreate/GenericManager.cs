using Cental.BusinessLayer.Abstract;
using Cental.DataAccesLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
    public class GenericManager<T> : IGenericService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;

        public GenericManager(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }

        public void TCreate(T entitiy)
        {
            _genericDal.Create(entitiy);    
        }

        public void TDelete(int id)
        {
          _genericDal.Delete(id);
        }

        public List<T> TGetAll()
        {
            return _genericDal.GetAll();
        }

        public T TGetById(int id)
        {
            return _genericDal.GetById(id);
        }

        public void TUpdate(T entitiy)
        {
            _genericDal.Update(entitiy);
        }
    }
}
