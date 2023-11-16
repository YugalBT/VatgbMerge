using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Se000300
    {
        public string Seoptnme { get; set; } = null!;
        public short Serescnt { get; set; }
        public short Sesorno1 { get; set; }
        public byte Useaccel { get; set; }
        public short Senocolm { get; set; }
        public short AccountsIncluded { get; set; }
        public int DexRowId { get; set; }
    }
}
