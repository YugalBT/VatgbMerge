using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa50100
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public decimal Balance { get; set; }
        public decimal OriginatingBalance { get; set; }
        public int Numofinv { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Error { get; set; }
        public int DexRowId { get; set; }
    }
}
