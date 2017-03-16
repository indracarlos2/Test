using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestorationStore.Domain;
using RestorationStore.Domain.Model;
namespace RestorationStore.Controllers
{
    public class ResponseController : Controller
    {
        Repository<Respons> responseContext = new Repository<Respons>();
        Repository<Request> requestContext = new Repository<Request>();
        [HttpGet]
        public ActionResult CreateResponse(int id_request) {
            Respons response = new Respons();
            Request request = requestContext.FindOneForId(id_request);
            response.Request = request;
            response.Cost = 1;
            response.Id_Request = request.Id;
            return View("CreateResponse",response);
        }

        [HttpPost]
        public ActionResult CreateResponse(Respons response, 
                                           HttpPostedFileBase image) {
            Request request = requestContext.FindOneForId(response.Id_Request);
            if(ModelState.IsValid) {
                if(image != null) {
                    response.ImageMimeType = image.ContentType;
                    response.FinalImage = new byte[image.ContentLength];
                    image.InputStream.Read(response.FinalImage, 0, image.ContentLength);
                   
                    response.FinalDate = System.DateTime.Now;
                    request.Estatus = "Completed";
                    responseContext.Add(response);
                    requestContext.Edit(request);
                    responseContext.Save();
                    requestContext.Save();
                    return RedirectToAction("Index", "Home");
                } else {
                    ModelState.AddModelError("","Please, load the final image.");
                }
            }
            response.Request = request;
            return View(response);
        }
        [HttpGet]
        public ActionResult GetAllResponses() {
            return View(responseContext.FindAll().OrderBy(p => p.FinalDate));
        }

        public FileContentResult GetImage(int id) {
            Respons response = responseContext.FindOneForId(id);
            if(response != null) {
                return File(response.FinalImage, response.ImageMimeType);
            } else {
                return null;
            }
        }

        [HttpGet]
        public ActionResult DetailResponse(int id) {
            Respons response = responseContext.FindOneForId(id);
            return View(response);
        }
    }
}
