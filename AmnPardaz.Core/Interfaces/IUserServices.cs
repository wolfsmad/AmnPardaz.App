﻿using AmnPardaz.Core.ModelViews;
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
    }
}
