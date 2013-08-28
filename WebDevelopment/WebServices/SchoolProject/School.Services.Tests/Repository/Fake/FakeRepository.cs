using School.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Services.Tests.Repository.Fake
{
    class FakeRepository<T> : IRepository<T> where T : class
    {
        public IList<T> entities = new List<T>();

        public T Add(T item)
        {
            this.entities.Add(item);
            return item;
        }

        public T Get(int id)
        {
            return this.entities[id];
        }

        public IQueryable<T> All()
        {
            return this.entities.AsQueryable();
        }

        public int Count()
        {
            return this.entities.Count;
        }

        IQueryable<T> IRepository<T>.All()
        {
            return this.entities.AsQueryable();
        }
    }
}