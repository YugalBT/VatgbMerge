using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00952
    {
        public string Itemnmbr { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public byte GoodStock { get; set; }
        public string Trnsfloc { get; set; } = null!;
        public string Itlocn { get; set; } = null!;
        public short Etadays { get; set; }
        public string Shipmthd { get; set; } = null!;
        public short UsedOptions { get; set; }
        public byte SvcItemSiteDelta { get; set; }
        public byte SvcCreateNonSerialEq { get; set; }
        public int DexRowId { get; set; }
    }
}
