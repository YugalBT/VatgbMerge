using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc00630
    {
        public string Ponumber { get; set; } = null!;
        public int Polnenum { get; set; }
        public decimal Encmbamt { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public int Invindx { get; set; }
        public string Actnumbr1 { get; set; } = null!;
        public string Actnumbr2 { get; set; } = null!;
        public string Actnumbr3 { get; set; } = null!;
        public string Actnumbr4 { get; set; } = null!;
        public string Actnumbr5 { get; set; } = null!;
        public string Actnumbr6 { get; set; } = null!;
        public string Actnumbr7 { get; set; } = null!;
        public string Actnumbr8 { get; set; } = null!;
        public string Actnumbr9 { get; set; } = null!;
        public string Actnumbr10 { get; set; } = null!;
        public string Actnumst { get; set; } = null!;
        public short Polnesta { get; set; }
        public short Encbstat { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public short Noninven { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Crusrid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Reqdate { get; set; }
        public DateTime Trxdate { get; set; }
        public short Periodid { get; set; }
        public string? Pername { get; set; }
        public short Year1 { get; set; }
    }
}
