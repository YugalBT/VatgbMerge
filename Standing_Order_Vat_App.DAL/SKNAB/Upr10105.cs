using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10105
    {
        public short Rptngyr { get; set; }
        public string Employid { get; set; } = null!;
        public decimal Statintx { get; set; }
        public decimal Statewgs { get; set; }
        public int Seqnumbr { get; set; }
        public string Statecd { get; set; } = null!;
        public string Estidnbr { get; set; } = null!;
        public byte W2printd { get; set; }
        public string Txentycd { get; set; } = null!;
        public string Othstdat { get; set; } = null!;
        public string Stcntrlnum { get; set; } = null!;
        public string Suppdat1 { get; set; } = null!;
        public string Suppdat2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
