using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrsax012
    {
        public short TableI { get; set; }
        public short RowI { get; set; }
        public short ColI { get; set; }
        public decimal SalarylowI { get; set; }
        public decimal SalarymedI { get; set; }
        public decimal SalaryhighI { get; set; }
        public int DexRowId { get; set; }
    }
}
