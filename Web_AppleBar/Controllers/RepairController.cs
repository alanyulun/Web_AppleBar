using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class RepairController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: Repair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RepairePriceInfo_Mac()
        {
            //var img=db.RepairPriceInfo_Mac.Where(m => m.ID !="0001").ToList();

            //return View(img);
            return View();
        }
    }
}