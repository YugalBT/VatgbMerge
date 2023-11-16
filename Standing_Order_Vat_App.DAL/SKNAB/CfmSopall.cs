using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class CfmSopall
    {
        public string Custnmbr { get; set; } = null!;
        public string Sopnumbe { get; set; } = null!;
        public short Soptype { get; set; }
        public DateTime Docdate { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public DateTime Date { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Amntpaid { get; set; }
        public int DexRowId { get; set; }
    }
}
