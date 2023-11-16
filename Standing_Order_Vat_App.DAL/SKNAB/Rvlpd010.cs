using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd010
    {
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public short Pdocstrm { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Ordocamt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Valstrg1 { get; set; } = null!;
        public string Valstrg2 { get; set; } = null!;
        public string Valstrg3 { get; set; } = null!;
        public string Valstrg4 { get; set; } = null!;
        public string Valstrg5 { get; set; } = null!;
        public string Valstrg6 { get; set; } = null!;
        public DateTime Valdate1 { get; set; }
        public DateTime Valdate2 { get; set; }
        public decimal Valcurr1 { get; set; }
        public decimal Valcurr2 { get; set; }
        public string Valbact1 { get; set; } = null!;
        public string Valbact2 { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Mkdbyusr { get; set; } = null!;
        public byte Mktoproc { get; set; }
        public short Remtype { get; set; }
        public string Remitid { get; set; } = null!;
        public decimal CmrecordNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
