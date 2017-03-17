using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RestorationStore.Infrastructure.Abstract;
using System.Web.Security;
using RestorationStore.Domain.Model;
using RestorationStore.Domain;
namespace RestorationStore.Infrastructure.Concrete {
    public class FormsAuthProvider : IAuthProvider {
        public bool Authenticate(string userName, string password) {
            Repository<Login> responseContext = new Repository<Login>();
            System.Linq.Expressions.Expression<Func<Login, bool>> expr =
                x => x.Usuario == userName;
            Login login = responseContext.FindOne(expr);
            if(login!=null&&login.Password.Equals(password)) {
                FormsAuthentication.SetAuthCookie(userName, false);
                System.Web.HttpContext.Current.Session["UserRole"] = login.Role;
                return true;
            }
            return false;
        }

        public void SignOut() {
            System.Web.HttpContext.Current.Session.RemoveAll();
            FormsAuthentication.SignOut();
        }
    }
}