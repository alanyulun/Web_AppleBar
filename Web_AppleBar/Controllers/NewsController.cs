﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class NewsController : Controller
    {
        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            var News = db.News.ToList();

            return View(News);
        }
    }
}