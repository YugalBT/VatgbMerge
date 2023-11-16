using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gtm20001v
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string MasterId { get; set; } = null!;
        public int AaTrxDimId { get; set; }
        public int AaTrxCodeId { get; set; }
        public string? AaTrxDimCode { get; set; }
        public string? Interid { get; set; }
        public int? Actindx { get; set; }
        public short? Accttype { get; set; }
        public short? Disttype { get; set; }
        public decimal? Debitamt { get; set; }
        public decimal? Crdtamnt { get; set; }
        public string? Curncyid { get; set; }
        public int? Seqnumbr { get; set; }
        public DateTime? Glpostdt { get; set; }
        public byte? Posted { get; set; }
        public byte? History { get; set; }
        public int DexRowId { get; set; }
    }
}
