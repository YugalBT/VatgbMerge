using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00315
    {
        public int Equipid { get; set; }
        public byte Active { get; set; }
        public string Schedid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
