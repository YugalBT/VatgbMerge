using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00700
    {
        public string Employid { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Txflgsts { get; set; } = null!;
        public byte Exmfblnd { get; set; }
        public byte Exfblsps { get; set; }
        public byte Exforo65 { get; set; }
        public byte Exmfrslf { get; set; }
        public byte Exmfspal { get; set; }
        public byte Exmfrsps { get; set; }
        public byte Exfspo65 { get; set; }
        public short Prsnexpt { get; set; }
        public short Depndnts { get; set; }
        public short Adnlalow { get; set; }
        public short Estdedal { get; set; }
        public decimal Exmtamnt { get; set; }
        public decimal Adstwhdg { get; set; }
        public decimal Eststwhd { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
