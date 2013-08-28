using System;
using System.Data.Entity;
using System.Linq;
using BlogSystem.Models;

namespace BlogSystem.Data
{
    public class BlogSystemContext : DbContext
    {
        public BlogSystemContext() :
            base("BlogSystemDb")
        {

        }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}