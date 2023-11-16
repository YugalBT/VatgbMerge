using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10103
    {
        public short Rptngyr { get; set; }
        public string Lastname { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Midlname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Socscnum { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public decimal Grosdist { get; set; }
        public byte Txbamndt { get; set; }
        public decimal Tamd1099 { get; set; }
        public byte Totdstcb { get; set; }
        public decimal Captlgain { get; set; }
        public decimal Feditxwh { get; set; }
        public decimal Emplectr { get; set; }
        public decimal Ntrealap { get; set; }
        public string Dstcode1 { get; set; } = null!;
        public string Dstcode2 { get; set; } = null!;
        public string Dstcode3 { get; set; } = null!;
        public byte Irasepcb { get; set; }
        public decimal Otam1099 { get; set; }
        public decimal Otpc1099 { get; set; }
        public decimal Ttltdstpc { get; set; }
        public decimal Statwgs1 { get; set; }
        public decimal Statwgs2 { get; set; }
        public decimal Staintx1 { get; set; }
        public decimal Staintx2 { get; set; }
        public string Statecd1 { get; set; } = null!;
        public string Statecd2 { get; set; } = null!;
        public string Estidnr1 { get; set; } = null!;
        public string Estidbr2 { get; set; } = null!;
        public decimal Lclwges1 { get; set; }
        public decimal Lclwgs2 { get; set; }
        public decimal Lclintx1 { get; set; }
        public decimal Lclintx2 { get; set; }
        public string Lclcode1 { get; set; } = null!;
        public string Lclcode2 { get; set; } = null!;
        public int Y1099rfc { get; set; }
        public int DexRowId { get; set; }
    }
}
