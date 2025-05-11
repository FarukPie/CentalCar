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
	public class ProcessManager : IProcessService
	{
		private readonly IProcessDal _processDal;

		public ProcessManager(IProcessDal processDal)
		{
			_processDal = processDal;
		}

		public void TCreate(Process entitiy)
		{
			_processDal.Create(entitiy);
		}

		public void TDelete(int id)
		{
			_processDal.Delete(id);
		}

		public List<Process> TGetAll()
		{
			return _processDal.GetAll();
		}

		public Process TGetById(int id)
		{
			return _processDal.GetById(id);
		}

		public void TUpdate(Process entitiy)
		{
			_processDal.Update(entitiy);
		}
	}
}
