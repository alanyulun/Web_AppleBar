using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceIphoneVM
    {
        public List<RepairPriceTable_Row_Iphone> RepairPriceTable_Row { get; set; }
        public List<RepairPriceTable_Col_Iphone> RepairPriceTable_Col { get; set; }
        public List<RepairPriceTable_Data_Iphone> RepairPriceTable_Data { get; set; }
    }
}