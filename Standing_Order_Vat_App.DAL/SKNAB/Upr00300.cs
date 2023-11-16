using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00300
    {
        public decimal Noteindx { get; set; }
        public string Employid { get; set; } = null!;
        public byte Exmfrfed { get; set; }
        public string Fdflgsts { get; set; } = null!;
        public short Fedexmpt { get; set; }
        public decimal Adfdwhdg { get; set; }
        public decimal Estfedwh { get; set; }
        public string Statecd { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public byte W2bf942e { get; set; }
        public byte W2bfdcsd { get; set; }
        public byte W2bfdcmp { get; set; }
        public byte W2bflrep { get; set; }
        public byte W2bfppln { get; set; }
        public byte W2bfstem { get; set; }
        public byte Mcrqgemp { get; set; }
        public string Eicflgst { get; set; } = null!;
        public byte Nytxdiff { get; set; }
        public int DexRowId { get; set; }
    }
}
