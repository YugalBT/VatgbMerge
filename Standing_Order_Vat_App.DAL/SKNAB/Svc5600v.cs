using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc5600v
    {
        public string RtvNumber { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public string RtvReturnStatus { get; set; } = null!;
        public short RtvStatus { get; set; }
        public string Retdocid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime Receiptdate { get; set; }
        public DateTime Compdte { get; set; }
        public string Offid { get; set; } = null!;
        public int History { get; set; }
        public int? DexRowId { get; set; }
    }
}
