using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr50000
    {
        public string Employid { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public byte Inactive { get; set; }
        public string Emplclas { get; set; } = null!;
        public string SupervisorcodeI { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
