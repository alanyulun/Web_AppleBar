using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class NewsController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();

        // GET: News
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult News()
        {
            var news = db.News.ToList();
            
            return View(news);
        }
    }
}