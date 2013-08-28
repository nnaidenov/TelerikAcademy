using BlogSystem.Data;
using BlogSystem.Models;
using BlogSystem.Repositories;
using BlogSystem.Services.Attributes;
using BlogSystem.Services.Models;
using BlogSystem.Services.Persisters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.ValueProviders;

namespace BlogSystem.Services.Controllers
{
    public class TagsController : BaseApiController
    {
        private readonly IRepository<Tag> tagRepository;

        public TagsController()
        {
            var dbContext = new BlogSystemContext();
            this.tagRepository = new DbTagRepository(dbContext);
        }

        public TagsController(IRepository<Tag> repository)
        {
            this.tagRepository = repository;
        }

        [HttpGet]
        public IQueryable<TagModel> GetAll(
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                var context = new BlogSystemContext();
                using (context)
                {
                    var user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                    if (user == null)
                    {
                        throw new InvalidOperationException("Invalid username or password");
                    }
                }

                var tags = this.tagRepository.All();

                var models =
                    (from t in tags
                     select new TagModel
                     {
                         Id = t.Id,
                         Name = t.Name,
                         Posts = t.Posts.Count
                     });

                return models.OrderBy(t => t.Name);
            });

            return responseMsg;
        }

        [HttpGet]
        [ActionName("GetPostsForTag")]
        public ICollection<PostModel> GetPostsForTag(int tagId,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                var context = new BlogSystemContext();
                using (context)
                {
                    var user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                    if (user == null)
                    {
                        throw new InvalidOperationException("Invalid username or password");
                    }
                }

                var tag = this.tagRepository.Get(tagId);

                var models =
                    (from t in tag.Posts
                     select new PostModel
                     {
                         Id = t.Id,
                         Title = t.Title,
                         PostDate = t.PostDate,
                         PostedBy = t.User.DisplayName,
                         Text = t.Text,
                         Tags = (from p in t.Tags
                                 select p.Name),
                         Comments = (from c in t.Comments
                                     select new CommendModel
                                     {
                                         Text = c.Content,
                                         CommentedBy = c.User.DisplayName,
                                         PostDate = c.CommentDate
                                     })
                     });

                return models.OrderBy(p => p.PostDate);
            });

            return responseMsg.ToList();
        }
    }
}