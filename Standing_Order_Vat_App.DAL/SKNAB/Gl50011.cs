using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl50011
    {
        public string Yearid { get; set; } = null!;
        public short Periodid { get; set; }
        public short Amntfrom { get; set; }
        public int Actindx { get; set; }
        public decimal Dollar1 { get; set; }
        public int Sqlsesid { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
