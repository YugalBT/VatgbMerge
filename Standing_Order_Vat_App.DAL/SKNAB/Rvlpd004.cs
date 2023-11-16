using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd004
    {
        public string Custnmbr { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
