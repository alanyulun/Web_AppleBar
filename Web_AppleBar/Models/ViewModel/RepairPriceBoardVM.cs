using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceBoardVM
    {
        public List<RepairPriceTable_Row_Board> RepairPriceTable_Row { get; set; }
        public List<RepairPriceTable_Col_Board> RepairPriceTable_Col { get; set; }
        public List<RepairPriceTable_Data_Board> RepairPriceTable_Data { get; set; }
    }
}