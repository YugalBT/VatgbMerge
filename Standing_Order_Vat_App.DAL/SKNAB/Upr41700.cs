using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41700
    {
        public string SupervisorcodeI { get; set; } = null!;
        public string Supervisor { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
