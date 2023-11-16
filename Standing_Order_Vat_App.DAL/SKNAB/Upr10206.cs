using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10206
    {
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public short Pyrntype { get; set; }
        public string Employid { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public decimal Ttlsttax { get; set; }
        public decimal Sttxtips { get; set; }
        public decimal Txblwags { get; set; }
        public decimal Txbltips { get; set; }
        public byte[] Bldcherr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
