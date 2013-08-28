using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public interface IRepository<T>
    {
        T Add(T item);
        T Get(int id);
        IQueryable<T> All();
    }
}