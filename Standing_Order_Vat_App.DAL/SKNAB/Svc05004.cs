using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05004
    {
        public string Vendorid { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public string DollarOrPercentReimbu1 { get; set; } = null!;
        public string DollarOrPercentReimbu2 { get; set; } = null!;
        public string DollarOrPercentReimbu3 { get; set; } = null!;
        public string DollarOrPercentReimbu4 { get; set; } = null!;
        public decimal ReimbursementAmount1 { get; set; }
        public decimal ReimbursementAmount2 { get; set; }
        public decimal ReimbursementAmount3 { get; set; }
        public decimal ReimbursementAmount4 { get; set; }
        public decimal ReimbursementNte1 { get; set; }
        public decimal ReimbursementNte2 { get; set; }
        public decimal ReimbursementNte3 { get; set; }
        public decimal ReimbursementNte4 { get; set; }
        public int DexRowId { get; set; }
    }
}
