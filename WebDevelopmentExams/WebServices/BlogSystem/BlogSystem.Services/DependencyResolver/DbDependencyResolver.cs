using BlogSystem.Data;
using BlogSystem.Repositories;
using BlogSystem.Services.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Dependencies;

namespace BlogSystem.Services.DependencyResolver
{
    public class DbDependencyResolver : IDependencyResolver
    {
        public IDependencyScope BeginScope()
        {
            return this;
        }

        public object GetService(Type serviceType)
        {
            if (serviceType == typeof(UsersController))
            {
                var context = new BlogSystemContext();
                var repository = new DbUserRepository(context);

                return new UsersController(repository);
            }
            else if (serviceType == typeof(PostsController))
            {
                var context = new BlogSystemContext();
                var repository = new DbPostRepository(context);

                return new PostsController(repository);
            }
            else if (serviceType == typeof(TagsController))
            {
                var context = new BlogSystemContext();
                var repository = new DbTagRepository(context);

                return new TagsController(repository);
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