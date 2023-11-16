using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00202
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public int Equipid { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public int Meter1 { get; set; }
        public int Meter2 { get; set; }
        public int Meter3 { get; set; }
        public DateTime Lstdtedt { get; set; }
        public byte Pmperf { get; set; }
        public int DexRowId { get; set; }
    }
}
