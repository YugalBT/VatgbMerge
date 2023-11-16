using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00701
    {
        public string Paequiptid { get; set; } = null!;
        public string Paeqnme { get; set; } = null!;
        public string Paequiptclsid { get; set; } = null!;
        public byte Painactive { get; set; }
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
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal Panoteindex { get; set; }
        public int DexRowId { get; set; }
    }
}
