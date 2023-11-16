using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn10200
    {
        public string QueryId { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public int QueryExecuteTime { get; set; }
        public int QueryTotalRecords { get; set; }
        public int QueryRecordsFound { get; set; }
        public decimal QueryTotalBalance { get; set; }
        public decimal QueryTotalPastDue { get; set; }
        public string QueryCurrentRecord { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
