using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00850
    {
        public string EcoNumber { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public decimal Noteindx { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string FromSerialNumber { get; set; } = null!;
        public string ToSerialNumber { get; set; } = null!;
        public byte Mandatory { get; set; }
        public string Srvtype { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
