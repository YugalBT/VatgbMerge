using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc600tv
    {
        public string Contnbr { get; set; } = null!;
        public decimal SvcContractLineSeq { get; set; }
        public DateTime? Compdte { get; set; }
        public decimal? Qtysold { get; set; }
    }
}
