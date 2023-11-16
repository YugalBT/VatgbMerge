using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0601v
    {
        public string Custnmbr { get; set; } = null!;
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public int Equipid { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Cnttype { get; set; } = null!;
        public decimal Labpct { get; set; }
        public int DexRowId { get; set; }
    }
}
