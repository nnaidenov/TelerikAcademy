using School.Data;
using School.Repositories;
using School.Services.Controllers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace School.Services.DependencyResolver
{
    public class DbDependecyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(UniversityController))
            {
                var context = new SchoolContext();
                var repository = new DbSchoolRepository(context);

                return new UniversityController(repository);
            }
            else if (serviceType == typeof(StudentController))
            {
                var context = new SchoolContext();
                var repository = new DbStudentRepository(context);

                return new StudentController(repository);
            }
            else
            {
                return null;
            }
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return new List<object>();
        }

        public void Dispose()
        {

        }
    }
}