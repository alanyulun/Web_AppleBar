﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class StoreInfoController : Controller
    {

        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: StoreInfo
        public ActionResult StoreInfo()
        {

  

            return View(db.StoreInformation.ToList());
        }
    }
}