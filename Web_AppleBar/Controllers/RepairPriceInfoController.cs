
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_AppleBar.Models;
using Web_AppleBar.Models.ViewModel;

namespace Web_AppleBar.Controllers
{
    


    public class RepairPriceInfoController : Controller
    {

        private AppleBar_dbEntities db = new AppleBar_dbEntities();

        // GET: Repair
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult RepairPriceInfo_Mac()
        {




            return View();
        }


        public ActionResult RepairPriceInfo_IPad()
        {




            return View();
        }

        public ActionResult RepairPriceInfo_IPhone()
        {




            return View();
        }


        public ActionResult RepairPriceInfo_Board()
        {

            var repairPriceInfo_Boards = new RepairPriceInfo_Board {repairPriceTable_Col_Boards=db.RepairPriceTable_Col_Board.OrderBy(m=>m.ID).ToList()
                ,repairPriceTable_Data_Boards=db.RepairPriceTable_Data_Board.ToList()
                ,repairPriceTable_Row_Boards=db.RepairPriceTable_Row_Board.ToList() };


            return View(repairPriceInfo_Boards);
        }


        public ActionResult RepairPriceInfo_HomeDelivery()
        {



            return View();
        }

    }
}