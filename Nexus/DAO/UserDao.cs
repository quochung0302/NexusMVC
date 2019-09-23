using Nexus.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nexus.DAO
{
    public class UserDao
    {
        NexusDbContext db = null;
        public UserDao()
        {
            db = new NexusDbContext();
        }
        public bool Login(string userName, string password)
        {
            var result = db.Users.Count(x => x.UserName == userName && x.Password == password);
            if(result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public User GetByName(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
    }
}