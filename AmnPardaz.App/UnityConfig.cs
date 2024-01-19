using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity.Mvc5;
using Unity;
using AmnPardaz.Core.Interfaces;
using AmnPardaz.Core.Services;
using System.Web.ApplicationServices;

namespace AmnPardaz.App
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();
            container.RegisterType<IUserServices, UserServices>();
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}