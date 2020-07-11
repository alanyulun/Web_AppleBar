using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class RepairCaseController : Controller
    {

        private AppleBar_dbEntities db = new AppleBar_dbEntities();



        public ActionResult RepairCase_IPhone()
        {
            var repairCase_IPhones = db.RepairCase_Iphone.ToList();



            return View(repairCase_IPhones);
        }

        public ActionResult RepairCase_IPad()
        {
            var repairCase_IPads = db.RepairCase_Ipad.ToList();



            return View(repairCase_IPads);
        }


        public ActionResult RepairCase_MacBook()
        {
            var repairCase_Boards = db.RepairCase_Macbook.ToList();



            return View(repairCase_Boards);
        }



    }
}