using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm30200
    {
        public string? Custnmbr { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public short? Soptype { get; set; }
        public DateTime? Docdate { get; set; }
        public DateTime? Duedate { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Amntpaid { get; set; }
        public int? DexRowId { get; set; }
    }
}
