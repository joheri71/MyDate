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
        public ActionResult Index()//I body returneras nu 4st slumpade användare
        {
            var context = new ApplicationDbContext();
            var users = new List<UserModel>();
            var randomUser = context.UserModels.OrderBy(u => Guid.NewGuid()).ToList();
            users.Add(randomUser[0]);
            users.Add(randomUser[1]);
            users.Add(randomUser[2]);
            users.Add(randomUser[3]);
  


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