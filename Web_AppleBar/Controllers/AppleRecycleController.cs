using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;

namespace Web_AppleBar.Controllers
{
    public class AppleRecycleController : Controller
    {
        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: AppleRecycle
        public ActionResult AppleRecycle_Ipad()
        {
            var appleRecycle_Ipad = db.AppleRecycle_Ipad.ToList();

            return View(appleRecycle_Ipad);
        }


        public ActionResult AppleRecycle_Iphone()
        {
            var appleRecycle_Iphone = db.AppleRecycle_Iphone.ToList();

            return View(appleRecycle_Iphone);
        }


        public ActionResult AppleRecycle_Mac()
        {
            var appleRecycle_Mac = db.AppleRecycle_Mac.ToList();

            return View(appleRecycle_Mac);
        }



    }
}