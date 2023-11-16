using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop00300
    {
        public string Custnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Subitemnmbr { get; set; } = null!;
        public string Subitemdesc { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public int DexRowId { get; set; }
    }
}
