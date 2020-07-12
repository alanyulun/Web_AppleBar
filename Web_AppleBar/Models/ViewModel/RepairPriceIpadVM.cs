using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceIpadVM
    {
        public List<RepairPriceTable_Row_Ipad> RepairPriceTable_Row { get; set; }
        public List<RepairPriceTable_Col_Ipad> RepairPriceTable_Col { get; set; }
        public List<RepairPriceTable_Data_Ipad> RepairPriceTable_Data { get; set; }
    }
}