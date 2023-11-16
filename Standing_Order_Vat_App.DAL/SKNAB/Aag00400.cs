using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00400
    {
        public int AaTrxDimId { get; set; }
        public string AaTrxDim { get; set; } = null!;
        public short AaDataType { get; set; }
        public string AaTrxDimDescr { get; set; } = null!;
        public string AaTrxDimDescr2 { get; set; } = null!;
        public int AaOrder { get; set; }
        public short Decplqty { get; set; }
        public string Uomschdl { get; set; } = null!;
        public byte AaAddrTrue { get; set; }
        public byte AaAddCodesOnFly { get; set; }
        public byte AaDontAskForNewCodes { get; set; }
        public decimal Noteindx { get; set; }
        public byte Inactive { get; set; }
        public int DexRowId { get; set; }
    }
}
