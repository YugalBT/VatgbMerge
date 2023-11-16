using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa30601
    {
        public string Papurordnum { get; set; } = null!;
        public int Ord { get; set; }
        public short Brkfld1 { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public decimal BackoutTradeDiscTax { get; set; }
        public byte CapitalItem { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal Denxrate { get; set; }
        public decimal Xchgrate { get; set; }
        public decimal Frtamnt { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal OrigBackoutTradeDiscTax { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public byte Pacbaddfrmfly { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int PacogsIdx { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public int PalineItemSeq { get; set; }
        public string Paprojname { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public short Patu { get; set; }
        public int Pacgbwipidx { get; set; }
        public string Pricelvl { get; set; } = null!;
        public decimal Qtycmtbase { get; set; }
        public decimal Qtyuncmtbase { get; set; }
        public short Ratecalc { get; set; }
        public decimal Trdisamt { get; set; }
        public int DexRowId { get; set; }
    }
}
