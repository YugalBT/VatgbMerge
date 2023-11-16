using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00201
    {
        public int AaAcctClassId { get; set; }
        public string AaAccountClass { get; set; } = null!;
        public string AaAcctClassDescr { get; set; } = null!;
        public string AaAcctClassDescr2 { get; set; } = null!;
        public byte AaSetCustId { get; set; }
        public byte AaSetVendId { get; set; }
        public byte AaSetItemId { get; set; }
        public byte AaSetSiteId { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
