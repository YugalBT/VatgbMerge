using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10204
    {
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public int Cmpntseq { get; set; }
        public int Lnitmseq { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public short Promosts { get; set; }
        public short Promotyp { get; set; }
        public decimal Psitmval { get; set; }
        public string Freeitem { get; set; } = null!;
        public string Freeuofm { get; set; } = null!;
        public int Prmcmseq { get; set; }
        public int Prmliseq { get; set; }
        public int DexRowId { get; set; }
    }
}
