﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class AppleBar_dbEntities : DbContext
    {
        public AppleBar_dbEntities()
            : base("name=AppleBar_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppleRecycle_Ipad> AppleRecycle_Ipad { get; set; }
        public virtual DbSet<AppleRecycle_Iphone> AppleRecycle_Iphone { get; set; }
        public virtual DbSet<AppleRecycle_Mac> AppleRecycle_Mac { get; set; }
        public virtual DbSet<IphoneRepair_Battery> IphoneRepair_Battery { get; set; }
        public virtual DbSet<IphoneRepair_Board> IphoneRepair_Board { get; set; }
        public virtual DbSet<IphoneRepair_Soaking> IphoneRepair_Soaking { get; set; }
        public virtual DbSet<MacbookRepair_Soaking> MacbookRepair_Soaking { get; set; }
        public virtual DbSet<RepairCase_Ipad> RepairCase_Ipad { get; set; }
        public virtual DbSet<RepairCase_Iphone> RepairCase_Iphone { get; set; }
        public virtual DbSet<RepairCase_Macbook> RepairCase_Macbook { get; set; }
        public virtual DbSet<RepairPriceTable_Col_Board> RepairPriceTable_Col_Board { get; set; }
        public virtual DbSet<RepairPriceTable_Col_HomeDelivery> RepairPriceTable_Col_HomeDelivery { get; set; }
        public virtual DbSet<RepairPriceTable_Col_Ipad> RepairPriceTable_Col_Ipad { get; set; }
        public virtual DbSet<RepairPriceTable_Col_Iphone> RepairPriceTable_Col_Iphone { get; set; }
        public virtual DbSet<RepairPriceTable_Col_Mac> RepairPriceTable_Col_Mac { get; set; }
        public virtual DbSet<RepairPriceTable_Data_Board> RepairPriceTable_Data_Board { get; set; }
        public virtual DbSet<RepairPriceTable_Data_HomeDelivery> RepairPriceTable_Data_HomeDelivery { get; set; }
        public virtual DbSet<RepairPriceTable_Data_Ipad> RepairPriceTable_Data_Ipad { get; set; }
        public virtual DbSet<RepairPriceTable_Data_Iphone> RepairPriceTable_Data_Iphone { get; set; }
        public virtual DbSet<RepairPriceTable_Data_Mac> RepairPriceTable_Data_Mac { get; set; }
        public virtual DbSet<RepairPriceTable_Row_Board> RepairPriceTable_Row_Board { get; set; }
        public virtual DbSet<RepairPriceTable_Row_HomeDelivery> RepairPriceTable_Row_HomeDelivery { get; set; }
        public virtual DbSet<RepairPriceTable_Row_Ipad> RepairPriceTable_Row_Ipad { get; set; }
        public virtual DbSet<RepairPriceTable_Row_Iphone> RepairPriceTable_Row_Iphone { get; set; }
        public virtual DbSet<RepairPriceTable_Row_Mac> RepairPriceTable_Row_Mac { get; set; }
        public virtual DbSet<News> News { get; set; }
        public virtual DbSet<MacUpgrade> MacUpgrade { get; set; }
        public virtual DbSet<StoreInformation> StoreInformation { get; set; }
    }
}
