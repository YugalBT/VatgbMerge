using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa50102
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public short Apfrdcty { get; set; }
        public string Apfrdcnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public decimal Apptoamt { get; set; }
        public decimal Oraptoam { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public string Fromcurr { get; set; } = null!;
        public short PaRefundApply { get; set; }
        public int DexRowId { get; set; }
    }
}
