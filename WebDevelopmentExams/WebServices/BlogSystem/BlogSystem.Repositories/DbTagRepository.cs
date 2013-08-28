using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Repositories
{
    public class DbTagRepository : IRepository<Tag>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<Tag> entitySet;

        public DbTagRepository(DbContext context)
        {
            this.dbContext = context;
            this.entitySet = this.dbContext.Set<Tag>();
        }

        public Tag Add(Tag item)
        {
            throw new NotImplementedException();
        }

        public Tag Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Tag> All()
        {
            return this.entitySet;
        }

        public Tag Update(Tag item, int id, bool flag)
        {
            throw new NotImplementedException();
        }
    }
}
