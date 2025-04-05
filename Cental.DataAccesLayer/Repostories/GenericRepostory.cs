using Cental.DataAccesLayer.Abstract;
using Cental.DataAccesLayer.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.DataAccesLayer.Repostories
{
    public class GenericRepostory<T> : IGenericDal<T> where T : class 
    {
        private readonly CentalContext _context;

        public GenericRepostory(CentalContext context)
        {
            _context = context;
        }

        public void Create(T entitiy)
        {
            _context.Add(entitiy);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var value = GetById(id);
            _context.Remove(value);
            _context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return _context.Set<T>().Find(id);

        }

        public void Update(T entitiy)
        {
            _context.Update(entitiy);
            _context.SaveChanges();

        }
    }
    
    }

