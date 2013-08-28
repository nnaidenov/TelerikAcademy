using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Models;

namespace School.Repositories
{
    public class DbSchoolRepository : IRepository<University>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<University> entitySet;

        public DbSchoolRepository(DbContext context)
        {
            this.dbContext = context;
            this.entitySet = this.dbContext.Set<University>();
        }

        public University Add(University item)
        {
            //Validation
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();

            return item;
        }

        public University Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<University> All()
        {
            return this.entitySet;
        }
    }
}