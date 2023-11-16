using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00306
    {
        public int Equipid { get; set; }
        public string EcoNumber { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
