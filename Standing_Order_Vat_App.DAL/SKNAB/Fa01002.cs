using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa01002
    {
        public DateTime Purgedate { get; set; }
        public DateTime Purgetime { get; set; }
        public string Userid { get; set; } = null!;
        public int Assetindex { get; set; }
        public string Assetid { get; set; } = null!;
        public short Assetidsuf { get; set; }
        public string Assetdesc { get; set; } = null!;
        public short Assetstatus { get; set; }
        public DateTime Assetstatdt { get; set; }
        public int DexRowId { get; set; }
    }
}
