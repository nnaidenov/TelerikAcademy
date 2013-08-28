﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Repositories
{
    public interface IRepository<T>
    {
        T Add(T item);
        T Get(int id);
        IQueryable<T> All();
        T Update(T item, int id, bool flag);
    }
}