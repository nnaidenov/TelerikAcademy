using BlogSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogSystem.Repositories
{
    public class DbPostRepository : IRepository<Post>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<Post> entitySet;

        public DbPostRepository(DbContext context)
        {
            this.dbContext = context;
            this.entitySet = this.dbContext.Set<Post>();
        }

        public Post Add(Post item)
        {
            this.dbContext.Set<User>().Attach(item.User);
            List<Tag> allTags = new List<Tag>();

            foreach (var tag in item.Tags)
            {
                var newTag = new Tag { Name = tag.Name };
                allTags.Add(newTag);
            }

            item.Tags.Clear();

            foreach (var tag in allTags)
            {
                if (this.dbContext.Set<Tag>().Where(t => t.Name == tag.Name).FirstOrDefault() != null)
                {
                    item.Tags.Add(this.dbContext.Set<Tag>().Where(t => t.Name == tag.Name).FirstOrDefault());
                }
                else
                {
                    item.Tags.Add(tag);
                }
            }

            this.entitySet.Add(item);
            this.dbContext.SaveChanges();

            return item;
        }

        public Post Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<Post> All()
        {
            return this.entitySet;
        }

        public Post Update(Post item, int id, bool flag)
        {
            this.dbContext.Set<User>().Attach(item.User);

            var post = this.entitySet.Find(id);
            foreach (var com in item.Comments)
            {
                if (com.User == null)
                {
                    com.User = item.User;
                }
                post.Comments.Add(com);
            }

            this.dbContext.SaveChanges();

            return item;
        }
    }
}
