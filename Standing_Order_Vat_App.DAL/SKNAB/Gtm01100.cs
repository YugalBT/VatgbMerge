using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm01100
    {
        public string Grantid { get; set; } = null!;
        public string Grantdesc { get; set; } = null!;
        public short Grantstatus { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Granttype { get; set; } = null!;
        public byte Validgrantperiod { get; set; }
        public short Grantperiodaction { get; set; }
        public byte Validgranttodate { get; set; }
        public short Granttodateaction { get; set; }
        public byte Validgrantlife { get; set; }
        public short Grantlifeaction { get; set; }
        public byte Validgranttotal { get; set; }
        public short Granttotaltype { get; set; }
        public short Granttotalaction { get; set; }
        public decimal Awardamount { get; set; }
        public byte Enablegrantbudget { get; set; }
        public int Uniquegrantid { get; set; }
        public decimal Noteindx { get; set; }
        public string AaTrxDim { get; set; } = null!;
        public string AaTrxDimCode { get; set; } = null!;
        public string Budgetid { get; set; } = null!;
        public short GtmBudgetValidationBy { get; set; }
        public int DexRowId { get; set; }
    }
}
