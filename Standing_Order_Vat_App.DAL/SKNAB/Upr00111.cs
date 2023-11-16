using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr00111
    {
        public string Employid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public short Relationship { get; set; }
        public string Commentstr20 { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Middleinitial { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Dependentssn { get; set; } = null!;
        public short Gender { get; set; }
        public DateTime Brthdate { get; set; }
        public string Homephone { get; set; } = null!;
        public string Workphone { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public byte Fltmstdntcb { get; set; }
        public int DexRowId { get; set; }
    }
}
