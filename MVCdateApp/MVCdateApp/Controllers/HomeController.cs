using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdateApp.Models;

namespace MVCdateApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var context = new ApplicationDbContext();
            var users = new List<UserModel>();
            var unOrderedUsers = context.UserModels.OrderBy(u => Guid.NewGuid()).ToList();
            users.Add(unOrderedUsers[0]);
            users.Add(unOrderedUsers[1]);
            users.Add(unOrderedUsers[2]);
            users.Add(unOrderedUsers[3]);
  


            //var db = new ApplicationDbContext();
            //List<UserModel> users = db.UserModels.ToList();


            return View(users);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}