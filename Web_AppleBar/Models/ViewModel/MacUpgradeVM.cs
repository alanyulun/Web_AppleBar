using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web_AppleBar.Models.ViewModel
{
    public class MacUpgradeVM
    {
        public MacUpgrade macUpgradeMain { get; set; }
        public List<MacUpgrade> macUpgradeSub { get; set; }


    }
}