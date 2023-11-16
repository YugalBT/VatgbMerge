using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm80500
    {
        public string Trxsorce { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Apfrdcnm { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Aptvchnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public decimal Appldamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public decimal Ten99amnt { get; set; }
        public decimal Disavtkn { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Aptodcdt { get; set; }
        public string Keysourc { get; set; } = null!;
        public decimal Orappamt { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Rlganlos { get; set; }
        public int DexRowId { get; set; }
    }
}
