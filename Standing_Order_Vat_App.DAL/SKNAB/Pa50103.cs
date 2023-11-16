using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa50103
    {
        public string Aptvchnm { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short Aptodcty { get; set; }
        public short Doctype { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public decimal Appldamt { get; set; }
        public DateTime Docdate { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
