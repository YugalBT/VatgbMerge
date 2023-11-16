using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy03300
    {
        public string Pymtrmid { get; set; } = null!;
        public short Duetype { get; set; }
        public short Duedtds { get; set; }
        public short Disctype { get; set; }
        public short Discdtds { get; set; }
        public short Dsclctyp { get; set; }
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public byte Salpurch { get; set; }
        public byte Discntcb { get; set; }
        public byte Freight { get; set; }
        public byte Misc { get; set; }
        public byte Tax { get; set; }
        public decimal Noteindx { get; set; }
        public byte Cbuvatmd { get; set; }
        public string Lstusred { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public byte Usegrper { get; set; }
        public int DexRowId { get; set; }
    }
}
