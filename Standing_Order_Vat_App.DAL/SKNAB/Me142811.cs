using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142811
    {
        public string Meardlid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string MeDownloadString { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
