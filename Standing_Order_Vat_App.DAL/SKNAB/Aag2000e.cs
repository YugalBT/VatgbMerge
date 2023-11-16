using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag2000e
    {
        public int AaSubLedgerHdrId { get; set; }
        public int AaSubLedgerDistId { get; set; }
        public int AaSubLedgerAssignId { get; set; }
        public int AaDisplayDistId { get; set; }
        public byte Aadocval { get; set; }
        public short AaErrorNum { get; set; }
        public int AaAcctClassId { get; set; }
        public string AaTrxDim { get; set; } = null!;
        public string AaTrxDimCode { get; set; } = null!;
        public string AaRelatedTrxDim { get; set; } = null!;
        public string AaRelatedTrxDimCode { get; set; } = null!;
        public string Errdescr { get; set; } = null!;
        public string AaAccountClass { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
