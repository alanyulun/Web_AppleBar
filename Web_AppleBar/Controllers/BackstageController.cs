using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;
using Web_AppleBar.Models.ViewModel;

namespace Web_AppleBar.Controllers
{
    public class BackstageController : Controller
    {
        private AppleBar_db_200706Entities db = new AppleBar_db_200706Entities();
        // GET: Background
        public ActionResult Index()
        {
            return View();
        }

        //Login & UserManage******************************************************
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginRequire(string account,string password)
        {
            BackstageUser data = db.BackstageUser.Find(account);
            if (data != null)
            {
                if (data.Password == password)
                    return RedirectToAction("UserManage", "BackStage");
            }

            return RedirectToAction("Login", "BackStage");
        }

        public ActionResult UserManage()
        {
            var Data = db.BackstageUser.ToList();

            return View(Data);
        }

        public ActionResult UserManage_Edit(string account)
        {
            var Data = db.BackstageUser.Find(account);
            if (Data != null)
                return View(Data);
            else
            {
                TempData["resultMsg"] = "資料有誤";
                return RedirectToAction("UserManage", "BackStage");
            }
        }

        [HttpPost]
        public ActionResult UserManage_Edit(BackstageUser postbackData)
        {
            var Data = db.BackstageUser.Find(postbackData.Account);

            Data.Account = postbackData.Account;
            Data.Password = postbackData.Password;
            Data.Name = postbackData.Name;
            Data.PhoneNum = postbackData.PhoneNum;
            Data.Remarks = postbackData.Remarks;

            db.SaveChanges();
            return RedirectToAction("UserManage", "BackStage");
        }

        [HttpPost]
        public ActionResult UserManage_Dele(string account)
        {
            var Data = db.BackstageUser.Find(account);
            db.BackstageUser.Remove(Data);
            db.SaveChanges();
            return RedirectToAction("UserManage", "BackStage");
        }

        public ActionResult UserManage_Creat()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UserManage_Creat(BackstageUser postbackData)
        {
            db.BackstageUser.Add(postbackData);
            db.SaveChanges();
            return RedirectToAction("UserManage", "BackStage");
        }
        //************************************************************************

        //News********************************************************************
        public ActionResult News()
        {
            var Data = db.News.ToList();

            return View(Data);
        }

        public ActionResult News_Edit(string id)
        {
            var Data = db.BackstageUser.Find(id);
            if (Data != null)
                return View(Data);
            else
            {
                TempData["resultMsg"] = "資料有誤";
                return RedirectToAction("News", "BackStage");
            }
        }
        //************************************************************************

        //IphoneRepaire***********************************************************
        public ActionResult IphoneRepair_Battery()
        {
            var Data = db.IphoneRepair_Battery.ToList();

            return View(Data);
        }

        public ActionResult IphoneRepair_Soaking()
        {
            var Data = db.IphoneRepair_Soaking.ToList();

            return View(Data);
        }

        public ActionResult IphoneRepair_Board()
        {
            var Data = db.IphoneRepair_Board.ToList();

            return View(Data);
        }
        //************************************************************************

        //MacbookRepair***********************************************************
        public ActionResult MacbookRepair_Soaking()
        {
            var Data = db.MacbookRepair_Soaking.ToList();

            return View(Data);
        }
        //************************************************************************

        //AppleRecycle************************************************************
        public ActionResult AppleRecycle_Iphone()
        {
            var Data = db.AppleRecycle_Iphone.ToList();

            return View(Data);
        }

        public ActionResult AppleRecycle_Ipad()
        {
            var Data = db.AppleRecycle_Ipad.ToList();

            return View(Data);
        }

        public ActionResult AppleRecycle_Mac()
        {
            var Data = db.AppleRecycle_Mac.ToList();

            return View(Data);
        }
        //************************************************************************

        //MacUpgrade**************************************************************
        public ActionResult MacUpgrade()
        {
            var Data = db.MacUpgrade.ToList();

            return View(Data);
        }
        //************************************************************************

        //RepairCase**************************************************************
        public ActionResult RepairCase_Iphone()
        {
            var Data = db.RepairCase_Iphone.ToList();

            return View(Data);
        }

        public ActionResult RepairCase_Ipad()
        {
            var Data = db.RepairCase_Ipad.ToList();

            return View(Data);
        }

        public ActionResult RepairCase_Macbook()
        {
            var Data = db.RepairCase_Macbook.ToList();

            return View(Data);
        }
        //************************************************************************

        //RrpairPriceTable********************************************************
        public ActionResult RrpairPriceTable_Iphone()
        {
            var Row = db.RepairPriceTable_Row_Iphone.ToList();
            var Col = db.RepairPriceTable_Col_Iphone.ToList();
            var Data = db.RepairPriceTable_Data_Iphone.ToList();
            var ShowData = new RepairPriceIphoneVM 
            {
                RepairPriceTable_Row = Row, 
                RepairPriceTable_Col = Col, 
                RepairPriceTable_Data = Data 
            };

            return View(ShowData);
        }

        public ActionResult RrpairPriceTable_Ipad()
        {
            var Row = db.RepairPriceTable_Row_Ipad.ToList();
            var Col = db.RepairPriceTable_Col_Ipad.ToList();
            var Data = db.RepairPriceTable_Data_Ipad.ToList();
            var ShowData = new RepairPriceIpadVM
            {
                RepairPriceTable_Row = Row,
                RepairPriceTable_Col = Col,
                RepairPriceTable_Data = Data
            };

            return View(ShowData);
        }

        public ActionResult RrpairPriceTable_Mac()
        {
            var Row = db.RepairPriceTable_Row_Mac.ToList();
            var Col = db.RepairPriceTable_Col_Mac.ToList();
            var Data = db.RepairPriceTable_Data_Mac.ToList();
            var ShowData = new RepairPriceMacVM
            {
                RepairPriceTable_Row = Row,
                RepairPriceTable_Col = Col,
                RepairPriceTable_Data = Data
            };

            return View(ShowData);
        }

        public ActionResult RrpairPriceTable_Board()
        {
            var Row = db.RepairPriceTable_Row_Board.ToList();
            var Col = db.RepairPriceTable_Col_Board.ToList();
            var Data = db.RepairPriceTable_Data_Board.ToList();
            var ShowData = new RepairPriceBoardVM
            {
                RepairPriceTable_Row = Row,
                RepairPriceTable_Col = Col,
                RepairPriceTable_Data = Data
            };

            return View(ShowData);
        }

        public ActionResult RrpairPriceTable_HomeDelivery()
        {
            var Row = db.RepairPriceTable_Row_HomeDelivery.ToList();
            var Col = db.RepairPriceTable_Col_HomeDelivery.ToList();
            var Data = db.RepairPriceTable_Data_HomeDelivery.ToList();
            var ShowData = new RepairPriceHomeDeliveryVM
            {
                RepairPriceTable_Row = Row,
                RepairPriceTable_Col = Col,
                RepairPriceTable_Data = Data
            };

            return View(ShowData);
        }
        //************************************************************************

        //StoreInformation********************************************************
        public ActionResult StoreInformation()
        {
            var Data = db.StoreInformation.ToList();

            return View(Data);
        }
        //************************************************************************
    }
}