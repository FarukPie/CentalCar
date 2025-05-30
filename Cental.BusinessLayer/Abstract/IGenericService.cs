﻿using Cental.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cental.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : BaseEntity
    {
        List<T> TGetAll();
        T TGetById(int id);
        void TDelete(int id);
        void TCreate(T entitiy);
        void TUpdate(T entitiy);
    }
}
