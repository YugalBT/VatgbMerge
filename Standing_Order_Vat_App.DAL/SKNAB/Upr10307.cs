using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10307
    {
        public short Mlchktyp { get; set; }
        public int Pyadnmbr { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public DateTime Posteddt { get; set; }
        public string Employid { get; set; } = null!;
        public byte Atacrvac { get; set; }
        public byte Atacrsck { get; set; }
        public decimal Grosamnt { get; set; }
        public decimal Netamnt { get; set; }
        public byte Mchkprtd { get; set; }
        public byte Mchkpstd { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
