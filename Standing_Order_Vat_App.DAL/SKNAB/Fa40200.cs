using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa40200
    {
        public int Bookindx { get; set; }
        public string Bookid { get; set; } = null!;
        public string Bookdesc { get; set; } = null!;
        public short Deprperiod { get; set; }
        public short Currfiscalyr { get; set; }
        public short Year1 { get; set; }
        public byte AutoAddBookInfo { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
