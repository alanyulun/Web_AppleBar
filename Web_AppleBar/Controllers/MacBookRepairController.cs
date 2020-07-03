using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class MacBookRepairController : Controller
    {
        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: MacBookRepair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SoakingRepair()
        {
            var Data = db.MacBookRepair_SoakingRepair.ToList();

            return View(Data);
        }
    }
}