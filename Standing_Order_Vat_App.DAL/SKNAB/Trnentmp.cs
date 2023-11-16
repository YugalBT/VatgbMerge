using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Trnentmp
    {
        public string EmpidI { get; set; } = null!;
        public string CourseidI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
