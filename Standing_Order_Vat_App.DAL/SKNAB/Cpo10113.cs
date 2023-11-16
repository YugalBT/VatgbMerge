using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cpo10113
    {
        public int? Jrnentry { get; set; }
        public decimal? Sqncline { get; set; }
        public string? DtacontrolNum { get; set; }
        public short? Dtatrxtype { get; set; }
        public int Actindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public DateTime? Trxdate { get; set; }
        public short? Year1 { get; set; }
        public short? Periodid { get; set; }
        public string? Bachnumb { get; set; }
        public string? Bchsourc { get; set; }
        public string? Sourcdoc { get; set; }
        public string? Refrence { get; set; }
        public int DexRowId { get; set; }
    }
}
