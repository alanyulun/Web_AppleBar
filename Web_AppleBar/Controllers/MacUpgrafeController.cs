using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;
using Web_AppleBar.Models.ViewModel;

namespace Web_AppleBar.Controllers
{
    public class MacUpgradeController : Controller
    {
        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: MacUpgrafe
        public ActionResult MacUpgrade()
        {
            var main=db.MacUpgrade.Where(m => m.ImgType == "main").FirstOrDefault();
            var sub= db.MacUpgrade.Where(m => m.ImgType == "sub").ToList();

            var result = new MacUpgradeVM { macUpgradeMain = main, macUpgradeSub = sub };

            return View(result);
        }
    }
}