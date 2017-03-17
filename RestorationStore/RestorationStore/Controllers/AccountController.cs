using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestorationStore.Infrastructure.Abstract;
using RestorationStore.Infrastructure.Concrete;
using RestorationStore.Domain.Model.ViewModel;
namespace RestorationStore.Controllers
{
    public class AccountController : Controller
    {
        IAuthProvider authProvider = new FormsAuthProvider();
        public ViewResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl) {
            if(ModelState.IsValid) {
                if(authProvider.Authenticate(model.Usuario, model.Password)) {
                    return Redirect(returnUrl ?? Url.Action("Index", "Home"));
                } else {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            } else {
                return View();
            }
        }

        [HttpGet]
        public ActionResult LogOut() {
            authProvider.SignOut();
            return RedirectToAction("Index","Home");
        }
    }
}
