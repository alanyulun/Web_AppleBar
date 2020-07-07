﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class IPhoneRepairController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: IPhoneRepair
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BatteryRepair()
        {
            var Data = db.IphoneRepair_Battery.ToList();

            return View(Data);
        }

        public ActionResult SoakingRepair()
        {
            var Data = db.IphoneRepair_Soaking.ToList();

            return View(Data);
        }
    }
}