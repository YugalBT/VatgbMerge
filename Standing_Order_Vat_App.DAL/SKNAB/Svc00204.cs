using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00204
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public string Schedid { get; set; } = null!;
        public string Pmdtlid { get; set; } = null!;
        public int Meter1Level { get; set; }
        public int DexRowId { get; set; }
    }
}
