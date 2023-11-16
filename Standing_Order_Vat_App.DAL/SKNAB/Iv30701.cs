using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv30701
    {
        public string Stckcntid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public string Baseuofm { get; set; } = null!;
        public decimal Countedqty { get; set; }
        public decimal Capturedqty { get; set; }
        public DateTime Cptrdt { get; set; }
        public DateTime Cptrtm { get; set; }
        public short Itmtrkop { get; set; }
        public string Ivdocnbr { get; set; } = null!;
        public short Ivdoctyp { get; set; }
        public decimal Unitcost { get; set; }
        public decimal Varianceqty { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public int DexRowId { get; set; }
    }
}
