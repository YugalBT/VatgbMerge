using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm20017v
    {
        public int AaGlhdrId { get; set; }
        public int AaGldistId { get; set; }
        public int AaGlassignId { get; set; }
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public short AaTrxtype { get; set; }
        public DateTime Glpostdt { get; set; }
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public string? AaTrxDimCode { get; set; }
        public string? Interid { get; set; }
        public int? Actindx { get; set; }
        public short? Accttype { get; set; }
        public decimal? Debitamt { get; set; }
        public decimal? Crdtamnt { get; set; }
        public string? Curncyid { get; set; }
        public int? Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
