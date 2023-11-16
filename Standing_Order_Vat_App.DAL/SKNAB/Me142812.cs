using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142812
    {
        public string Mebankid { get; set; } = null!;
        public short MeTransactionType { get; set; }
        public string MeTransactionCode { get; set; } = null!;
        public short Mestatustype { get; set; }
        public string Metrxstatcode { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
