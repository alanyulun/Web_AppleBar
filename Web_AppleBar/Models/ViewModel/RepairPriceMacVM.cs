using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceMacVM
    {
        public List<RepairPriceTable_Row_Mac> RepairPriceTable_Row { get; set; }
        public List<RepairPriceTable_Col_Mac> RepairPriceTable_Col { get; set; }
        public List<RepairPriceTable_Data_Mac> RepairPriceTable_Data { get; set; }
    }
}