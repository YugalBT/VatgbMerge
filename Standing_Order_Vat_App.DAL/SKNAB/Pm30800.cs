using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm30800
    {
        public string Vendorid { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Poprctnm { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public byte TaxInvRecvd { get; set; }
        public decimal Gstdsamt { get; set; }
        public int DexRowId { get; set; }
    }
}
