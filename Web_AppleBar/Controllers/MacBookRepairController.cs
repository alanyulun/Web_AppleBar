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
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: MacBookRepair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SoakingRepair()
        {
            var Data = db.MacbookRepair_Soaking.ToList();

            return View(Data);
        }
    }
}