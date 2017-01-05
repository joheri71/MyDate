using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCdateApp.Models;

namespace MVCdateApp.Controllers
{
    [Authorize]
    public class ImageController : Controller
    {

        [Authorize]
        [HttpPost]
        public ActionResult UserImage(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            {
                var filename = Path.GetFileName(file.FileName);
                var pathname = Path.Combine(Server.MapPath("~/Content/Images"), filename);
                //Saves the picture in Images
                file.SaveAs(pathname);


            }

            return RedirectToAction("Profile", "User");
        }


        public static void UploadImage(string username, string image)
        {
            using (var db = new ApplicationDbContext())
            {
                UserModel userImage = db.UserModels.FirstOrDefault(x => x.FullName == username);
                userImage.Image = image;
                db.SaveChanges();
            }
        }
    }
}