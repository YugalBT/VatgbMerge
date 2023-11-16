using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Tea25230
    {
        public string EmpidI { get; set; } = null!;
        public short SeqorderI { get; set; }
        public byte TermcompletedcbI { get; set; }
        public string TerminationitemI { get; set; } = null!;
        public string PersonresponsibleI { get; set; } = null!;
        public DateTime EventenddateI { get; set; }
        public int DexRowId { get; set; }
    }
}
