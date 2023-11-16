using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00112
    {
        public string Employid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string University { get; set; } = null!;
        public string Degree { get; set; } = null!;
        public string Major { get; set; } = null!;
        public string Gpa { get; set; } = null!;
        public string Gpabase { get; set; } = null!;
        public string Graduationyear { get; set; } = null!;
        public string Years { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
