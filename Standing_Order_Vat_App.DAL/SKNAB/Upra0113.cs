using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upra0113
    {
        public string Employid { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Emergencycontact { get; set; } = null!;
        public string Emergencyrelation { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Homephone { get; set; } = null!;
        public string Workphone { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
