using Nexus.Areas.Admin.Models;
using Nexus.Common;
using Nexus.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nexus.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View("Login");
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                var result = dao.Login(model.UserName, model.Password);
                if (result)
                {
                    var user = dao.GetByName(model.UserName);
                    var userSession = new UserLogin();
                    userSession.UserName = user.UserName;
                    userSession.UserID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession );
                    return RedirectToAction("Index", "Home");

                }
                else
                {
                    ModelState.AddModelError("UserWrong","Đăng nhập thất bại!");
                    return View("Login");

                }
            }
            return View("Login");

        }
    }
}