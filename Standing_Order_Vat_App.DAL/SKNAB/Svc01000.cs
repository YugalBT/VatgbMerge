using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc01000
    {
        public string Itemnmbr { get; set; } = null!;
        public byte Active { get; set; }
        public string Schedid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
