using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Dd10100
    {
        public string Employid { get; set; } = null!;
        public string Emplname { get; set; } = null!;
        public byte Printed { get; set; }
        public byte Voided { get; set; }
        public DateTime Chekdate { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public int Pyadnmbr { get; set; }
        public string Socscnum { get; set; } = null!;
        public decimal Ntwpyrn { get; set; }
        public decimal Grwgprn { get; set; }
        public DateTime Sttpyprd { get; set; }
        public DateTime Enpayprd { get; set; }
        public byte Inactive { get; set; }
        public byte Ddvoided { get; set; }
        public byte Ddmaskdlr { get; set; }
        public short Ddsupchk { get; set; }
        public short Ddnbraccts { get; set; }
        public string Ddatrxcode1 { get; set; } = null!;
        public string Ddatrxcode2 { get; set; } = null!;
        public string Ddatrxcode3 { get; set; } = null!;
        public string Ddatrxcode4 { get; set; } = null!;
        public string Ddatrxcode5 { get; set; } = null!;
        public string Ddatrxcode6 { get; set; } = null!;
        public string Ddatrxcode7 { get; set; } = null!;
        public string Ddatrxcode8 { get; set; } = null!;
        public string Ddatrxcode9 { get; set; } = null!;
        public string Ddatrxcode10 { get; set; } = null!;
        public string Ddatrxcode11 { get; set; } = null!;
        public string Ddatrxcode12 { get; set; } = null!;
        public string Ddatransit1 { get; set; } = null!;
        public string Ddatransit2 { get; set; } = null!;
        public string Ddatransit3 { get; set; } = null!;
        public string Ddatransit4 { get; set; } = null!;
        public string Ddatransit5 { get; set; } = null!;
        public string Ddatransit6 { get; set; } = null!;
        public string Ddatransit7 { get; set; } = null!;
        public string Ddatransit8 { get; set; } = null!;
        public string Ddatransit9 { get; set; } = null!;
        public string Ddatransit10 { get; set; } = null!;
        public string Ddatransit11 { get; set; } = null!;
        public string Ddatransit12 { get; set; } = null!;
        public string Ddaaccount1 { get; set; } = null!;
        public string Ddaaccount2 { get; set; } = null!;
        public string Ddaaccount3 { get; set; } = null!;
        public string Ddaaccount4 { get; set; } = null!;
        public string Ddaaccount5 { get; set; } = null!;
        public string Ddaaccount6 { get; set; } = null!;
        public string Ddaaccount7 { get; set; } = null!;
        public string Ddaaccount8 { get; set; } = null!;
        public string Ddaaccount9 { get; set; } = null!;
        public string Ddaaccount10 { get; set; } = null!;
        public string Ddaaccount11 { get; set; } = null!;
        public string Ddaaccount12 { get; set; } = null!;
        public decimal Ddaamount1 { get; set; }
        public decimal Ddaamount2 { get; set; }
        public decimal Ddaamount3 { get; set; }
        public decimal Ddaamount4 { get; set; }
        public decimal Ddaamount5 { get; set; }
        public decimal Ddaamount6 { get; set; }
        public decimal Ddaamount7 { get; set; }
        public decimal Ddaamount8 { get; set; }
        public decimal Ddaamount9 { get; set; }
        public decimal Ddaamount10 { get; set; }
        public decimal Ddaamount11 { get; set; }
        public decimal Ddaamount12 { get; set; }
        public string Errdescr { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
