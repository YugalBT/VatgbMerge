using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Te022330
    {
        public string TermsetupcodeI { get; set; } = null!;
        public short SeqorderI { get; set; }
        public string TerminationitemI { get; set; } = null!;
        public string PersonresponsibleI { get; set; } = null!;
        public DateTime EventenddateI { get; set; }
        public int DexRowId { get; set; }
    }
}
