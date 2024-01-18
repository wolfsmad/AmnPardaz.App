using AmnPardaz.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AmnPardaz.Domain;

using AmnPardaz.Core.ModelViews;
namespace AmnPardaz.Core.Services
{
    public class UserServices : IUserServices
    {
        private readonly APDatabaseEntities _context;
        public UserServices(APDatabaseEntities context)
        {
            _context = context;
        }

        public bool Loginuser(LoginModelView user)
        {
            var login = _context.Users.FirstOrDefault
                (u=>u.UserName == user.UserName && u.Password == user.Password);
            return login != null;
        }
    }
}
