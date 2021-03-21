using Microsoft.EntityFrameworkCore;
using MyBlog.Data.IService;
using System.Linq;

namespace MyBlog.Data.Service
{
    public class UserService : IUserService
    {
        private readonly DatabaseContext dc;
        public UserService(DatabaseContext dc)
        {
            this.dc = dc;
        }
        public int AddUser(User user)
        {
            dc.User.Add(user);
            return dc.SaveChanges();
        }

        public int DeleteUser(int id)
        {
            var user = dc.User.First(c => c.Id == id);
            dc.User.Remove(user);
            return dc.SaveChanges();
        }

        public int UpdateUser(User user)
        {
            dc.User.Attach(user);
            dc.Entry(user).State = EntityState.Modified;
            return dc.SaveChanges();
        }

        public User GetUserByAccount(string account)
        {
            return dc.User.First(c => c.Account.ToLower() == account.ToLower());
        }
    }
}
