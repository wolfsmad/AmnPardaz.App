using AmnPardaz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmnPardaz.Domain;

using AmnPardaz.Core.ModelViews;
using System.Data.Entity;
namespace AmnPardaz.Core.Services
{
    public class UserServices : IUserServices
    {
        private readonly APDatabaseEntities _context;
        public UserServices(APDatabaseEntities context)
        {
            _context = context;
        }

        public List<UserWeek> GetUserInformation(int userId)
        {
            List<UserWeek> userWeekData = _context.UserWeeks
                  .Where(uw => uw.UserId == userId)
                  .ToList();
            return userWeekData;
        }
        public int GetUserIdByUserName(string userName)
        {
            return _context.Users.Single(u => u.UserName == userName).UserId; ;
        }
        public bool Loginuser(LoginModelView user)
        {
            var login = _context.Users.FirstOrDefault
                (u => u.UserName == user.UserName && u.Password == user.Password);
            return login != null;
        }
    }
}
