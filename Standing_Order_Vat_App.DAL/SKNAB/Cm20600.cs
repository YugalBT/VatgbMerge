using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20600
    {
        public decimal XfrRecordNumber { get; set; }
        public string Cmxfrnum { get; set; } = null!;
        public decimal Cmfrmrecnum { get; set; }
        public decimal Cmtorecnum { get; set; }
        public short Cmfrmstatus { get; set; }
        public short Cmtostatus { get; set; }
        public string Cmfrmchkbkid { get; set; } = null!;
        public string Cmchkbkid { get; set; } = null!;
        public DateTime Cmxftdate { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
