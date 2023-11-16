using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class TravellersCheque
    {
        public DateTime? Date { get; set; }
        public string? Purchaser { get; set; }
        public string? PurchaserLastName { get; set; }
        public string? PurchaserFirstName { get; set; }
        public decimal? Amount { get; set; }
        public bool? BankCustomer { get; set; }
        public string? PaymentType { get; set; }
        public bool DeleteFlg { get; set; }
        public string? TheUser { get; set; }
        public string? TheMachine { get; set; }
    }
}
