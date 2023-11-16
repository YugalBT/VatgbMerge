using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Edcml001
    {
        public short Cmpanyid { get; set; }
        public byte MlcEnableMlchecks { get; set; }
        public string Userid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public int DexRowId { get; set; }
    }
}
