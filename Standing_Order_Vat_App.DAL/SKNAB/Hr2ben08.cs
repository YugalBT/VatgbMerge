using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben08
    {
        public string EmpidI { get; set; } = null!;
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public DateTime Date1 { get; set; }
        public string BenefittypeI { get; set; } = null!;
        public short BenefitstatusI { get; set; }
        public byte Inactive { get; set; }
        public byte OverrideI { get; set; }
        public decimal IbenefitamountI { get; set; }
        public decimal LifeamtemplI { get; set; }
        public decimal LifeamtspouseI { get; set; }
        public decimal LifeamtchildrenI { get; set; }
        public decimal CostemployeeI { get; set; }
        public decimal CostemployerI { get; set; }
        public decimal Costother1I { get; set; }
        public decimal Costother2I { get; set; }
        public decimal Costother3I { get; set; }
        public short NumberofchildrenI { get; set; }
        public decimal CosttotalI { get; set; }
        public decimal CostcobraI { get; set; }
        public int DexRowId { get; set; }
    }
}
