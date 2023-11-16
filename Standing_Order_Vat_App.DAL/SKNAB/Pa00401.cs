using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00401
    {
        public string PafeeId { get; set; } = null!;
        public string PafeeName { get; set; } = null!;
        public short PafeeType { get; set; }
        public short Pafrequency { get; set; }
        public decimal PapercentCost { get; set; }
        public decimal PapercentRevenue { get; set; }
        public decimal PaRetentionPercent { get; set; }
        public short PafeeToUse { get; set; }
        public decimal PafeeAmount { get; set; }
        public short PasalesTaxOptions { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Parenew { get; set; }
        public DateTime ParenewalDate { get; set; }
        public decimal Panoteindex { get; set; }
        public short PaRenewDay { get; set; }
        public short PaRenewMonth { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
