using AmnPardaz.Core.Interfaces;
using AmnPardaz.Core.ModelViews;
using AmnPardaz.Core.Services;
using AmnPardaz.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace AmnPardaz.App.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserServices _userServices;
        public HomeController(IUserServices userServices)
        {
            _userServices = userServices;
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModelView model)
        {
            if (ModelState.IsValid)
            {
                bool isSuccessLogin = _userServices.Loginuser(model);
                if (isSuccessLogin)
                {
                    FormsAuthentication.SetAuthCookie(model.UserName, false);
                    return RedirectToAction("Information");
                }
            }
            ModelState.AddModelError("", "Invalid userName and Password");
            return View(model);
        }
        [Route("Information")]
        [Authorize]
        [HttpGet]
        public ActionResult Information()
        {
            int userId = _userServices.GetUserIdByUserName(User.Identity.Name);
            var userInformation = _userServices.GetUserInformation(userId);
            return View(userInformation);
        }

        [Authorize]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}