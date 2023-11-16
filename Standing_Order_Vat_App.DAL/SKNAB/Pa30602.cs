using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa30602
    {
        public string Papurordnum { get; set; } = null!;
        public int Ord { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public int Actindx { get; set; }
        public decimal Orpurtax { get; set; }
        public decimal Paotdtp { get; set; }
        public decimal Paotdtt { get; set; }
        public short Potype { get; set; }
        public decimal Pctaxamt { get; set; }
        public decimal Txdttpur { get; set; }
        public decimal Tdttxpur { get; set; }
        public string Vendorid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
