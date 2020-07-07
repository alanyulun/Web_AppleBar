using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class BackgroundController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: Background
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            return View();
        }

        public ActionResult IphoneRepaire_Battery()
        {
            var Data = db.IphoneRepair_Battery.ToList();

            return View(Data);
        }

        public ActionResult IphoneRepaire_Soaking()
        {
            var Data = db.IphoneRepair_Soaking.ToList();

            return View(Data);
        }

        public ActionResult IphoneRepaire_Board()
        {
            var Data = db.IphoneRepair_Board.ToList();

            return View(Data);
        }
    }
}