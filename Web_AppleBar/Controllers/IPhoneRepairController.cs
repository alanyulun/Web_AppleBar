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
            var iphoneRepair_Batteries = db.IphoneRepair_Battery.ToList();

            return View(iphoneRepair_Batteries);
        }

        public ActionResult SoakingRepair()
        {
            var iphoneRepair_Soakings = db.IphoneRepair_Soaking.ToList();

            return View(iphoneRepair_Soakings);
        }


        public ActionResult BoardRepair()
        {
            var iphoneRepair_Boards = db.IphoneRepair_Board.ToList();

            return View(iphoneRepair_Boards);
        }
    }
}