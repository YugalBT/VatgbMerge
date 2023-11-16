using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr30401
    {
        public string Auctrlcd { get; set; } = null!;
        public string Srcecode { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int Actindx { get; set; }
        public DateTime Posteddt { get; set; }
        public int DexRowId { get; set; }
    }
}
