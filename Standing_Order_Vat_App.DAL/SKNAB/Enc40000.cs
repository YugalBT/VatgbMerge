using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc40000
    {
        public short Cmpanyid { get; set; }
        public byte Enabled { get; set; }
        public short Liqdoptn { get; set; }
        public short Tolcoptn { get; set; }
        public decimal Tolrance { get; set; }
        public byte[] Password { get; set; } = null!;
        public short Trkgoptn { get; set; }
        public short Encvldmthd { get; set; }
        public short Encmode { get; set; }
        public int DexRowId { get; set; }
    }
}
