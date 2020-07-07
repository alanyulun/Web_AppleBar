
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class RepairePriceInfoController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: Repair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult RepairPriceInfo_Mac()
        {
            //var img=db.RepairPriceInfo_Mac.Where(m => m.ID !="1").ToList();

            //return View(img);
            return View();
        }

        public ActionResult RepairPriceInfo_IPad()
        {
            //var img = db.RepairPriceInfo_IPad.Where(m => m.ID != "1").ToList();

            //return View(img);
            return View();
        }

        public ActionResult RepairPriceInfo_IPhone()
        {
            //var img = db.RepairPriceInfo_IPhone.Where(m => m.ID != "1").ToList();

            //return View(img);
            return View();
        }

        public ActionResult RepairPriceInfo_Board()
        {
            //var img = db.RepairPriceInfo_Board.Where(m => m.ID != "1").ToList();

            //return View(img);
            return View();
        }

        public ActionResult RepairPriceInfo_HomeDelivery()
        {
            //var img = db.RepairPriceInfo_HomeDelivery.Where(m => m.ID != "1").ToList();

            //return View(img);
            return View();
        }
    }
}