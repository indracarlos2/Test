using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RestorationStore.Controllers;
using RestorationStore.Domain.Model;
using RestorationStore.Domain;
namespace RestorationStore.Controllers
{ 
    [Authorize]
    public class GraphicController : Controller
    {
        Repository<Respons> responseContext = new Repository<Respons>();
        public ActionResult Index(){
            if(!"ShopOwner".Equals((String)Session["UserRole"])) {
                return RedirectToAction("Index", "Home");
            }
            MakeCost(DateTime.Now);
            return View();
        }

        [HttpPost]
        public ActionResult Index(String date) {
             MakeCost(DateTime.Now);
            return View();
        }

        private void MakeCost(DateTime date) {
            TempData["SalesGoal"] = 10000;
            TempData["CurrentSales"] = GetCostForWeek(date);
        }
        private decimal GetCostForWeek(DateTime date) {
            int dias = DayOfWeek.Saturday - date.DayOfWeek + 1;
            DateTime dateFinal = date.AddDays(dias);
            DateTime dateInitial = dateFinal.AddDays(-6);
            System.Linq.Expressions.Expression<Func<Respons, bool>> expr =
           x => x.FinalDate >= dateInitial && x.FinalDate <= dateFinal;
           return responseContext.Find(expr).Sum(o => o.Cost);
        }
    }
}
