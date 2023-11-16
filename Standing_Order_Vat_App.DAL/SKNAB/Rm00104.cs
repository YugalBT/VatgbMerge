using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00104
    {
        public string Custnmbr { get; set; } = null!;
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public short Histtype { get; set; }
        public int Numofinv { get; set; }
        public decimal Smrysals { get; set; }
        public decimal Smrycrcd { get; set; }
        public decimal Smrycost { get; set; }
        public decimal Smrywrof { get; set; }
        public decimal Smrydisc { get; set; }
        public decimal Smryrtng { get; set; }
        public decimal Smryfchr { get; set; }
        public decimal Smrywfch { get; set; }
        public decimal Smryrtrn { get; set; }
        public int DexRowId { get; set; }
    }
}
