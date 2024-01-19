using AmnPardaz.Core.ModelViews;
using AmnPardaz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmnPardaz.Core.Interfaces
{
    public interface IUserServices
    {
        bool Loginuser(LoginModelView user);
        List<UserWeek> GetUserInformation(int userId);
        int GetUserIdByUserName(string userName);
    }
}
