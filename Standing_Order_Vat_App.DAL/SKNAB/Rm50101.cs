using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm50101
    {
        public string Userid { get; set; } = null!;
        public short Prcssqnc { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public string Stsdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
