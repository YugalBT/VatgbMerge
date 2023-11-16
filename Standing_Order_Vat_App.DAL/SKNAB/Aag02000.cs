using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag02000
    {
        public string Userid { get; set; } = null!;
        public int AaTrxDimId { get; set; }
        public int AaTrxDimCodeId { get; set; }
        public byte AaView { get; set; }
        public byte AaEdit { get; set; }
        public byte AaDistribute { get; set; }
        public byte AaAdjust { get; set; }
        public byte AaBudgetView { get; set; }
        public byte AaBudgetAssign { get; set; }
        public int DexRowId { get; set; }
    }
}
