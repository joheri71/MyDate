using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdateApp.Models;

namespace MVCdateApp.Controllers
{
    public class UserController : Controller
    {
        // GET: UserModel
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Profile(int id)
        {
          
            var db = new ApplicationDbContext();
            var user = db.UserModels.Single(u => u.Id == id);


            return View(user);
        }



        // GET: UserModel/Details
        public ActionResult Details()
        {
            var userModel = new UserModel
            {
                FirstName = "Tord",
                LastName = "Yvel",
                Age = 30,
                Sex = true,
                City = "Stockholm",
                Country = "Sweden",
                Description = "En massa info!"
            };
            return View(userModel);
        }

        // GET: UserModel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserModel/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserModel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserModel/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: UserModel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserModel/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
