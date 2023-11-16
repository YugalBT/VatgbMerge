using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa50105
    {
        public string Userid { get; set; } = null!;
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Vchrnmbr { get; set; } = null!;
        public short Moduleid { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public string CustVenId { get; set; } = null!;
        public decimal Curtrxam { get; set; }
        public decimal Orctrxam { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Voidstts { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ordatkn { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public decimal Gstdsamt { get; set; }
        public decimal Ppsamded { get; set; }
        public int DexRowId { get; set; }
    }
}
