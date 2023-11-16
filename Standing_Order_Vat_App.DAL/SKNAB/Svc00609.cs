using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00609
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Seqnumbr { get; set; }
        public short SvcDistributionType { get; set; }
        public string DistRef { get; set; } = null!;
        public int Actindx { get; set; }
        public int DexRowId { get; set; }
    }
}
