using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40300
    {
        public string Deprtmnt { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string AddlDesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
