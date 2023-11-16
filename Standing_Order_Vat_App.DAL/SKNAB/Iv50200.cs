using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv50200
    {
        public byte Includeitem { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public string Itmclscd { get; set; } = null!;
        public short Abccode { get; set; }
        public string Itmgedsc { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public DateTime Lstcntdt { get; set; }
        public short Stckcntintrvl { get; set; }
        public DateTime Nxtcntdt { get; set; }
        public DateTime Nxtcnttm { get; set; }
        public byte Updated { get; set; }
        public short Itemtype { get; set; }
        public string Userid { get; set; } = null!;
        public short IntegerValue { get; set; }
        public int DexRowId { get; set; }
    }
}
