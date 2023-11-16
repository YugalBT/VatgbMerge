using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05003
    {
        public string RtvType { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Itlocn { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string RtvReturnStatus { get; set; } = null!;
        public string RtvShippingStatus { get; set; } = null!;
        public string RtvReceivedStatus { get; set; } = null!;
        public string RtvClosedStatus { get; set; } = null!;
        public short RtvRouting { get; set; }
        public int SvcPurchaseIndex { get; set; }
        public int SvcCostIndex { get; set; }
        public int SvcReimbursementIndex { get; set; }
        public string SvcReadyToShipStatus { get; set; } = null!;
        public string SvcPartialShippedStat { get; set; } = null!;
        public string SvcPartialReceivedSta { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
