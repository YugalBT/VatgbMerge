using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc10102
    {
        public string Invcnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public short Qtytype { get; set; }
        public int Sltsqnum { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serltnum { get; set; } = null!;
        public decimal Serltqty { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public decimal Unitcost { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Posted { get; set; }
        public short Ovrserlt { get; set; }
        public DateTime Mfgdate { get; set; }
        public DateTime Expndate { get; set; }
        public int DexRowId { get; set; }
    }
}
