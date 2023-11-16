using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben10
    {
        public string EmpidI { get; set; } = null!;
        public DateTime Bnfbegdt { get; set; }
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public string BenefittypeI { get; set; } = null!;
        public short IindexI { get; set; }
        public string PolicynumberI { get; set; } = null!;
        public string GroupnumberI { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public short BenefitstatusI { get; set; }
        public byte Inactive { get; set; }
        public byte OverrideI { get; set; }
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public byte Check3I { get; set; }
        public byte Check4I { get; set; }
        public byte Check5I { get; set; }
        public DateTime DatedueI { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Commentstr10I { get; set; } = null!;
        public decimal IbenefitamountI { get; set; }
        public decimal LifeamtemplI { get; set; }
        public decimal LifeamtspouseI { get; set; }
        public decimal LifeamtchildrenI { get; set; }
        public DateTime BeneligibiledateI { get; set; }
        public DateTime Bnfenddt { get; set; }
        public byte Varbenft { get; set; }
        public short Bnftfreq { get; set; }
        public decimal CostemployeeI { get; set; }
        public decimal CostemployerI { get; set; }
        public decimal Costother1I { get; set; }
        public decimal Costother2I { get; set; }
        public decimal Costother3I { get; set; }
        public short I2I { get; set; }
        public short I3I { get; set; }
        public short I4I { get; set; }
        public short NumberofchildrenI { get; set; }
        public decimal CosttotalI { get; set; }
        public decimal CostcobraI { get; set; }
        public decimal BenefitdeductibleI { get; set; }
        public decimal Bnpaypmx { get; set; }
        public decimal Bnfyrmax { get; set; }
        public decimal Bnflfmax { get; set; }
        public int BeneficiaryindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public decimal ContribpretaxI { get; set; }
        public decimal ContpretaxdlrI { get; set; }
        public decimal ContribaftertaxI { get; set; }
        public decimal ContaftertaxdlrI { get; set; }
        public decimal ContribbonusI { get; set; }
        public decimal ContribbonusdollarI { get; set; }
        public byte HighlycompensatedI { get; set; }
        public byte LoanactiveI { get; set; }
        public int DexRowId { get; set; }
    }
}
