using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn30200
    {
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short RevisionNumber { get; set; }
        public DateTime RevisionDate { get; set; }
        public DateTime RevisionTime { get; set; }
        public string Userid { get; set; } = null!;
        public short ActionType { get; set; }
        public decimal ActionAmount { get; set; }
        public decimal Curtrxam { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int DexRowId { get; set; }
    }
}
