using MultilevelCascadingDropDown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MultilevelCascadingDropDown.Controllers
{
    public class HomeController : Controller
    {
        task1Entities db = new task1Entities();
        public ActionResult Index()
        {
            List<CountryMaster> countries = db.CountryMasters.ToList();
            ViewBag.countries = new SelectList(countries, "pkCountryId", "ukCountryName", "");
            return View();
        }
        public JsonResult GetStateList(int pkCountryId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<StateMaster> StateList = db.StateMasters.Where(x => x.refCountryId == pkCountryId).ToList();
            return Json(StateList, JsonRequestBehavior.AllowGet);
        }
        public JsonResult GetCityList(int pkStateId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            List<CityMaster> CityList = db.CityMasters.Where(x => x.refStateId == pkStateId).ToList();
            return Json(CityList, JsonRequestBehavior.AllowGet);
        }
    }
}