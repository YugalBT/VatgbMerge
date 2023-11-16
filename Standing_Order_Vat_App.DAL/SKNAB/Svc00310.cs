using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00310
    {
        public int Equipid { get; set; }
        public int Lnitmseq { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Userid { get; set; } = null!;
        public string FromCustomerNumber { get; set; } = null!;
        public string ToCustomerNumber { get; set; } = null!;
        public string FromConfigReference { get; set; } = null!;
        public string ToConfigReference { get; set; } = null!;
        public short FromConfgLevel { get; set; }
        public short ToConfigLevel { get; set; }
        public short FromConfigSequence { get; set; }
        public short ToConfigSequence { get; set; }
        public string FromSerialNumber { get; set; } = null!;
        public string ToSerialNumber { get; set; } = null!;
        public string FromItemNumber { get; set; } = null!;
        public string ToItemNumber { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
