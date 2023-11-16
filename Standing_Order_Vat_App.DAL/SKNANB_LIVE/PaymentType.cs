using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class PaymentType
    {
        public int IdPaymentType { get; set; }
        public string NmPaymentType { get; set; } = null!;
        public int IdCompany { get; set; }
        /// <summary>
        /// Indicates if this payment type should be in SSB report
        /// </summary>
        public bool? Ssb { get; set; }
        public string Abbrev { get; set; } = null!;
        public decimal Ssee { get; set; }
        public decimal Slee { get; set; }
        public decimal Sser { get; set; }
        public decimal Sler { get; set; }
        public bool? LwrLimit { get; set; }
        public bool? UprLimit { get; set; }
        public bool Deleted { get; set; }
    }
}
