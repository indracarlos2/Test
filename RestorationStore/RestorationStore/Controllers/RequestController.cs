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

        [HttpGet]
        public ActionResult StartRequest(int id_request) {
            System.Linq.Expressions.Expression<Func<Request, bool>>
               expr = x => x.Id == id_request;
            return View(requestContext.FindOne(expr));
        }

        [HttpPost]
        public string SetInProgress(int  id_request) {
            System.Linq.Expressions.Expression<Func<Request, bool>>
               expr = x => x.Id == id_request;
            Request request = requestContext.FindOne(expr);
            if(request != null) {
                request.Estatus = "In progress";
                requestContext.Edit(request);
                requestContext.Save();
                return "<h2>Thanks!!!Request initialized correctly</h2>";
            }
            return "<h2>Sorry!!!The request does not exist!!!</h2>";
        }

        [HttpGet]
        public ActionResult SetInStop(int id_request) {
            System.Linq.Expressions.Expression<Func<Request, bool>>
               expr = x => x.Id == id_request;
            Request request = requestContext.FindOne(expr);
            return View(request);
        }

        [HttpPost]
        public string SetInStopRequest(int id_request) {
            System.Linq.Expressions.Expression<Func<Request, bool>>
               expr = x => x.Id == id_request;
            Request request = requestContext.FindOne(expr);
            if(request != null) {
                request.Estatus = "Pending";
                requestContext.Edit(request);
                requestContext.Save();
                return "<h2>The request has been stopped</h2>";
            }
            return "<h2>Sorry!!!The request does not exist!!!</h2>";
        }

        public FileContentResult GetImage(int id_request) {
            Request request = requestContext.FindOneForId(id_request);
            if(request != null) {
                return File(request.InitialImage, request.ImageMimeType);
            } else {
                return null;
            }
        }
    }
}
