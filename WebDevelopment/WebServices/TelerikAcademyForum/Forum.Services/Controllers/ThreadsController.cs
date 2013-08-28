using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Forum.Services.Models;
using Forum.Data;
using System.Web.Http.ValueProviders;
using Forum.Services.Attributes;

namespace Forum.Services.Controllers
{
    public class ThreadsController : BaseController
    {
        [HttpGet]
        public IQueryable<ThreadModel> GetAll(
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                var context = new ForumContext();

                var user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                if (user == null)
                {
                    throw new InvalidOperationException("Invalid username or password");
                }

                var threadEntities = context.Threads;
                var models =
                    (from threadEntity in threadEntities
                     select new ThreadModel()
                     {
                         Id = threadEntity.Id,
                         Title = threadEntity.Title,
                         DateCreated = threadEntity.DateCreated,
                         Content = threadEntity.Content,
                         CreatedBy = threadEntity.CreatedBy.Nickname,
                         Posts = (from postEntity in threadEntity.Posts
                                  select new PostModel()
                                  {
                                      Content = postEntity.Content,
                                      PostDate = postEntity.PostDate,
                                      PostedBy = postEntity.PostedBy.Nickname
                                  }),
                         Categories = (from categoryEntity in threadEntity.Categories
                                       select categoryEntity.Name)
                     });

                return models.OrderByDescending(thr => thr.DateCreated);
            });

            return responseMsg;
        }

        [HttpGet]
        public IQueryable<ThreadModel> GetPage(int page, int count,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var models = this.GetAll(sessionKey);
            models.Skip(page * count).Take(count);

            return models;
        }

        [HttpGet]
        public IQueryable<ThreadModel> GetByCategory(string category,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var models = this.GetAll(sessionKey)
                .Where(th => th.Categories.Any(c => c == category));

            return models;
        }

        [HttpGet]
        [ActionName("posts")]
        public IEnumerable<PostModel> GetPostsByThreadId(int threadId,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                var context = new ForumContext();

                var user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                if (user == null)
                {
                    throw new InvalidOperationException("Invalid username or password");
                }

                var postEntities = context.Threads.Where(thr => thr.Id == threadId).FirstOrDefault().Posts;
                var models =
                   (from postEntity in postEntities
                    select new PostModel 
                    {
                        Content = postEntity.Content,
                        PostDate = postEntity.PostDate,
                        PostedBy = postEntity.PostedBy.Nickname
                    });

                return models;
            });

            return responseMsg;
        }
    }
}