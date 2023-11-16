using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa40601
    {
        public string Emplclas { get; set; } = null!;
        public short PaemployeeType { get; set; }
        public short PaEmployedBy { get; set; }
        public string PapayCode { get; set; } = null!;
        public string PaunitOfMeasure { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public short PatmprofitType { get; set; }
        public decimal PatmprofitAmount { get; set; }
        public decimal PatmprofitPercent { get; set; }
        public short PaprofitTypeCp { get; set; }
        public decimal PaprofitAmountCp { get; set; }
        public decimal PaprofitPercentCp { get; set; }
        public short PaffprofitType { get; set; }
        public decimal PaffprofitAmount { get; set; }
        public decimal PaffprofitPercent { get; set; }
        public string Vendorid { get; set; } = null!;
        public short PaoverheadRateMethod { get; set; }
        public decimal PaovhdAmtPerUnit { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public int DexRowId { get; set; }
    }
}
