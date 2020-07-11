using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class RepairPriceInfo_Board
    {
        public List<RepairPriceTable_Data_Board> repairPriceTable_Data_Boards { get; set; }
        public List<RepairPriceTable_Col_Board> repairPriceTable_Col_Boards { get; set; }

        public List<RepairPriceTable_Row_Board> repairPriceTable_Row_Boards { get; set; }
    }
}