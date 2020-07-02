using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class IPhoneRepairController : Controller
    {
        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: IPhoneRepair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BatteryRepair()
        {
            var Data = db.IPhoneRepair_BatteryRepaire.ToList();

            return View(Data);
        }
    }
}