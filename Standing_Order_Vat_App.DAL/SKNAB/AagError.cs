using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagError
    {
        public string Actdescr { get; set; } = null!;
        public int AaGlworkHdrId { get; set; }
        public int Jrnentry { get; set; }
        public short AaErrorNum { get; set; }
        public string AaTrxDim { get; set; } = null!;
        public int AaGlworkDistId { get; set; }
        public int Actindx { get; set; }
        public string? AaTrxDimDescr { get; set; }
        public string AaAccountClass { get; set; } = null!;
        public string AaTrxDimCode { get; set; } = null!;
        public int AaAcctClassId { get; set; }
        public int DexRowId { get; set; }
        public string Userid { get; set; } = null!;
        public int AaGlworkAssignId { get; set; }
        public string AaRelatedTrxDim { get; set; } = null!;
        public string AaRelatedTrxDimCode { get; set; } = null!;
    }
}
