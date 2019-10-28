using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JSONTest.Models.Home;

namespace JSONTest.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetUsers()
        {
            List<User> users = new List<User>();
            users.Add(new User() { Age = 15, Name = "Dima" });
            users.Add(new User() { Age = 19, Name = "Matvey" });
            users.Add(new User() { Age = 12, Name = "Anton" });

            var usersJSON = users;

            return Json(usersJSON, JsonRequestBehavior.AllowGet);
        }
    }
}