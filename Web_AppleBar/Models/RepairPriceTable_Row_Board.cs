//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web_AppleBar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class RepairPriceTable_Row_Board
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RepairPriceTable_Row_Board()
        {
            this.RepairPriceTable_Data_Board = new HashSet<RepairPriceTable_Data_Board>();
        }
    
        public string ID { get; set; }
        public string Name { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RepairPriceTable_Data_Board> RepairPriceTable_Data_Board { get; set; }
    }
}
