using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01122
    {
        public string Pacontnumber { get; set; } = null!;
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public decimal Patotchgordamt { get; set; }
        public decimal Pacobaseprojamt { get; set; }
        public decimal Pacobslnfeeprojamt { get; set; }
        public int DexRowId { get; set; }
    }
}
