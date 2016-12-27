using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;
using MyDate.Models;

namespace MyDate.Controllers
{
    [AllowAnonymous]//Tillåter att sidan visas utan att vara inloggad
    public class AuthController : Controller
    {
        // GET: Auth
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult LogIn(LoginModel model)
        {
            if (!ModelState.IsValid) //Kontrollerar att inputformat är korrek.
            {
                return View(model);
            }

            //detta är bara tillfälligt.
            if (model.Email == "admin@admin.com" && model.Password == "123456")
            {
                var identity = new ClaimsIdentity(new[]
                {
                    new Claim(ClaimTypes.Name, "Danne"),
                    new Claim(ClaimTypes.Email, "danne@email.com"),
                    new Claim(ClaimTypes.Country, "Sweden")
                },
                        "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }

            ModelState.AddModelError("","Invalid email or password");
            return View(model);
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if (string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }

        public ActionResult Logout()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("Login", "Auth");
        }
    }
}