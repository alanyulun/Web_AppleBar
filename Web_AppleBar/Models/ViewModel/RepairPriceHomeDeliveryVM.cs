using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceHomeDeliveryVM
    {
        public List<RepairPriceTable_Row_HomeDelivery> RepairPriceTable_Row { get; set; }
        public List<RepairPriceTable_Col_HomeDelivery> RepairPriceTable_Col { get; set; }
        public List<RepairPriceTable_Data_HomeDelivery> RepairPriceTable_Data { get; set; }
    }
}