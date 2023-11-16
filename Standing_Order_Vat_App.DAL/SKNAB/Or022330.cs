using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Or022330
    {
        public string OrsetupcodeI { get; set; } = null!;
        public short SeqorderI { get; set; }
        public string OrientationitemI { get; set; } = null!;
        public string PersonresponsibleI { get; set; } = null!;
        public DateTime EventstartdateI { get; set; }
        public string EventstarttimeI { get; set; } = null!;
        public DateTime EventenddateI { get; set; }
        public string EventendtimeI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
