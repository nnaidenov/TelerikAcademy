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
    public class PostsController : BaseApiController
    {
        private readonly IRepository<Post> postRepository;

        public PostsController()
        {
            var dbContext = new BlogSystemContext();
            this.postRepository = new DbPostRepository(dbContext);
        }

        public PostsController(IRepository<Post> repository)
        {
            this.postRepository = repository;
        }

        [HttpGet]
        public IQueryable<PostModel> GetAll(
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

                var posts = this.postRepository.All();

                var models =
                    (from p in posts
                     select new PostModel
                     {
                         Id = p.Id,
                         Title = p.Title,
                         PostDate = p.PostDate,
                         PostedBy = p.User.DisplayName,
                         Text = p.Text,
                         Tags = (from t in p.Tags
                                 select t.Name),
                         Comments = (from c in p.Comments
                                     select new CommendModel
                                     {
                                         Text = c.Content,
                                         CommentedBy = c.User.DisplayName,
                                         PostDate = c.CommentDate
                                     })
                     });

                return models.OrderByDescending(d => d.PostDate);
            });

            return responseMsg;
        }

        [HttpGet]
        public IQueryable<PostModel> GetPage(int page, int count,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var models = this.GetAll(sessionKey).Skip(page * count).Take(count);

            return models;
        }

        [HttpGet]
        public IQueryable<PostModel> GetByTags(string tags,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {

            List<PostModel> filt = new List<PostModel>();
            var splitTags = tags.Split(',');

            var models = this.GetAll(sessionKey);

            var posts = models.ToList();

            foreach (var post in posts)
            {
                int tagCounter = 0;
                foreach (var tag in splitTags)
                {
                    if (post.Tags.Contains(tag))
                    {
                        tagCounter++;
                    }
                }
                if (tagCounter == splitTags.Length)
                {
                    filt.Add(post);
                }
            }

            return filt.AsQueryable();
        }

        [HttpGet]
        public IQueryable<PostModel> GetByKeyword(string keyword,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var models = this.GetAll(sessionKey).Where(c => c.Title.Contains(keyword));

            return models;
        }

        [HttpPost]
        public HttpResponseMessage PostPost(CreatePostModel model,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                User user;
                var context = new BlogSystemContext();
                using (context)
                {
                    user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                    if (user == null)
                    {
                        throw new InvalidOperationException("Invalid username or password");
                    }
                }

                Dictionary<string, Tag> tags = new Dictionary<string, Tag>();

                foreach (var tag in model.Tags)
                {
                    var tagToLower = tag.ToLower();
                    if (!tags.ContainsKey(tagToLower))
                    {
                        Tag newTag = new Tag { Name = tagToLower };
                        tags.Add(tagToLower, newTag);
                    }
                }

                var titleTags = model.Title.Split(' ');

                foreach (var tag in titleTags)
                {
                    var tagToLower = tag.ToLower();
                    if (!tags.ContainsKey(tagToLower))
                    {
                        Tag newTag = new Tag { Name = tagToLower };
                        tags.Add(tagToLower, newTag);
                    }
                }

                List<Tag> filtTags = new List<Tag>();

                foreach (var tag in tags.Values)
                {
                    filtTags.Add(tag);
                }

                var newPost = new Post
                {
                    Title = model.Title,
                    Text = model.Text,
                    Tags = filtTags,
                    PostDate = DateTime.Now,
                    User = user,
                };

                var dbPost = this.postRepository.Add(newPost);

                var postMode = new CreatedPostModel
                {
                    Id = dbPost.Id,
                    Title = dbPost.Title
                };

                var response = this.Request.CreateResponse(HttpStatusCode.Created, postMode);
                response.Headers.Location = new Uri(Url.Link("DefaultApi", new { id = postMode.Id }));

                return response;
            });

            return responseMsg;
        }

        [HttpPut]
        [ActionName("addcomment")]
        public HttpResponseMessage AddComent(CreateCommentModel model, int postId,
             [ValueProvider(typeof(HeaderValueProviderFactory<string>))] string sessionKey)
        {
            var responseMsg = ExceptionHandler(
            () =>
            {
                User user;
                var context = new BlogSystemContext();
                using (context)
                {
                    user = context.Users.FirstOrDefault(u => u.SessionKey == sessionKey);
                    if (user == null)
                    {
                        throw new InvalidOperationException("Invalid username or password");
                    }
                }

                var selectedPost = this.postRepository.Get(postId);

                var newComment = new Comment
                {
                    Content = model.Text,
                    CommentDate = DateTime.Now,
                    Post = selectedPost,
                    //User = user,
                };

                selectedPost.Comments.Add(newComment);
                this.postRepository.Update(selectedPost, postId, true);

                var response = this.Request.CreateResponse(HttpStatusCode.OK);

                return response;
            });

            return responseMsg;
        }
    }
}