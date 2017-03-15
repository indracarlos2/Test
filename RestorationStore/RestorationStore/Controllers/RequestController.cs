using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestorationStore.Domain.Model;
using RestorationStore.Domain;
namespace RestorationStore.Controllers
{
    public class RequestController : Controller
    {
        Repository<Request> requestContext = new Repository<Request>();
        [HttpGet]
        public ActionResult Index(){
            return View("CreateRequest");
        }

        [HttpPost]
        public ActionResult CreateRequest(Request request,
                                          HttpPostedFileBase image) {
            if(ModelState.IsValid) {
                if(image != null) {
                    request.ImageMimeType = image.ContentType;
                    request.InitialImage = new byte[image.ContentLength];
                    image.InputStream.Read(request.InitialImage, 0, image.ContentLength);
                }
                request.Estatus = "Pending";
                request.InitialDate = System.DateTime.Now;
              
               requestContext.Add(request);
               requestContext.Save();
                return RedirectToAction("Index","Home");
            }
            return View(request);
        }
    }
}
