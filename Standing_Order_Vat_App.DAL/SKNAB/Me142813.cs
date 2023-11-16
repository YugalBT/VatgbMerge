using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142813
    {
        public string Mebankid { get; set; } = null!;
        public short MeLineType { get; set; }
        public string MeLineCode { get; set; } = null!;
        public short MeRecordLength { get; set; }
        public short MeRecordNumberOfFields { get; set; }
        public int DexRowId { get; set; }
    }
}
