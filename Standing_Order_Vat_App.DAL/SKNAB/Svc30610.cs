using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30610
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public int Equipid { get; set; }
        public byte Active { get; set; }
        public string Schedid { get; set; } = null!;
        public short SvcContractVersion { get; set; }
        public int DexRowId { get; set; }
    }
}
