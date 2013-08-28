using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogSystem.Models;

namespace BlogSystem.Repositories
{
    public class DbUserRepository : IRepository<User>
    {
        private readonly DbContext dbContext;
        private readonly DbSet<User> entitySet;

        private static readonly Random rand = new Random();
        private const int SessionKeyLength = 50;
        private const string ValidSessionKeyCharacters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";

        public DbUserRepository(DbContext context)
        {
            this.dbContext = context;
            this.entitySet = this.dbContext.Set<User>();
        }

        public User Add(User item)
        {
            //Validation
            this.entitySet.Add(item);
            this.dbContext.SaveChanges();

            return item;
        }

        public User Get(int id)
        {
            return this.entitySet.Find(id);
        }

        public IQueryable<User> All()
        {
            return this.entitySet;
        }

        public User Update(User item, int id, bool flagForLogin)
        {
            var user = this.entitySet.Find(id);

            if (flagForLogin == true)
            {
                if (user.SessionKey == null)
                {
                    user.SessionKey = this.GenerateSessionKey(id);
                }
                else if (user.SessionKey != null)
                {
                    throw new InvalidOperationException("Invalid username or password");
                }
            }
            else
            {
                if (user.SessionKey != null)
                {
                    user.SessionKey = null;
                }
                else if (user.SessionKey == null)
                {
                    throw new InvalidOperationException("Invalid username or password");
                }
            }

            this.dbContext.SaveChanges();

            return user;
        }

        private string GenerateSessionKey(int userId)
        {
            StringBuilder sessionKey = new StringBuilder();
            sessionKey.Append(userId);

            while (sessionKey.Length < SessionKeyLength)
            {
                int index = rand.Next(ValidSessionKeyCharacters.Length);
                sessionKey.Append(ValidSessionKeyCharacters[index]);
            }

            return sessionKey.ToString();
        }
    }
}