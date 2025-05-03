using Cental.DataAccesLayer.Abstract;
using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Concreate
{
    public class ProcessManager : GenericManager<Process>
    {
        public ProcessManager(IGenericDal<Process> genericDal) : base(genericDal)
        {
        }
    }
}
