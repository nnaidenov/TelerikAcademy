using School.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Repositories
{
    public class DbStudentRepository : IRepository<Student>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<Student> entitySet;

        public DbStudentRepository(DbContext context)
        {
            this.dbContext = context;
            this.entitySet = this.dbContext.Set<Student>();
        }

        public Student Add(Student item)
        {
            //Validation
            var studet = this.entitySet.Where(s => s.StudentNumber == item.StudentNumber);

            if (studet != null)
            {
                throw new InvalidOperationException("This Studen number exists");
            }

            this.entitySet.Add(item);
            this.dbContext.SaveChanges();

            return item;
        }

        public Student Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Student> All()
        {
            return this.entitySet;
        }
    }
}