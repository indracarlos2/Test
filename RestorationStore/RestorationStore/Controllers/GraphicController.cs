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
            if(TempData["CurrentSales"] == null) {
                MakeCost(DateTime.Now);
            }
            return View();
        }

        [HttpGet]
        public bool GetCurrenSales(string id) {
            if(id!=null){
                string da= id.Substring(0,id.IndexOf("T"));
                string[] dates = da.Split('-');
                if(dates.Length == 3) {
                    DateTime date = new DateTime(Int32.Parse(dates[0]),
                                                 Int32.Parse(dates[1]),
                        Int32.Parse(dates[2]));
                    MakeCost(date);
                    return true;
                }
               
               
            }
            return false;
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
            string titleReport = "Sales report for " + dateInitial.ToShortDateString() + " and " + dateFinal.ToShortDateString();
            TempData["TitleReport"] = titleReport;
            return responseContext.Find(expr).Sum(o => o.Cost);
        }
    }
}
