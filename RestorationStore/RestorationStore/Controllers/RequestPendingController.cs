using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestorationStore.Domain.Model;
using RestorationStore.Domain;
namespace RestorationStore.Controllers
{
    public class RequestPendingController : Controller
    {
        Repository<RequestsPending> requestsPendingContext = new Repository<RequestsPending>();
       [HttpGet]
        public ActionResult Index(){
            return View("ListRequestsPending", requestsPendingContext.FindAll());
        }

        [HttpPost]
        public ActionResult ListRequestsPending(int id_request) {
            return View();
        }

        public FileContentResult GetImage(int ID) {
            System.Linq.Expressions.Expression<Func<RequestsPending, bool>>
                expr = x => x.ID == ID;
          RequestsPending request = requestsPendingContext.FindOne(expr);
          if(request != null) {
              return File(request.INITIALIMAGE, request.IMAGEMIMETYPE);
            } else {
                return null;
            }
        }

    }
}
