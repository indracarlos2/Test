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

        public ActionResult StartRequest(int id_request) {
            return RedirectToAction("StartRequest",  
                                         "Request", 
                                         new { id_request=id_request });
        }

    }
}
