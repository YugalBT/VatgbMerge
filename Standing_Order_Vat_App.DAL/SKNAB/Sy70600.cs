using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy70600
    {
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short ReportSelection { get; set; }
        public byte Asectmnt { get; set; }
        public byte Prtoflnt { get; set; }
        public byte Prtoprnt { get; set; }
        public byte Prtoscnt { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Xprtftyp { get; set; }
        public string Rprtname { get; set; } = null!;
        public int DexRowId { get; set; }
        public string NamedPrinters { get; set; } = null!;
    }
}
