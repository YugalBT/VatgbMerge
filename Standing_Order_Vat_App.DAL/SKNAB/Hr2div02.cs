using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2div02
    {
        public string CompanycodeI { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public string DivisionI { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipcodeI { get; set; } = null!;
        public string Phone10I { get; set; } = null!;
        public string ExtI { get; set; } = null!;
        public string FaxnumberiI { get; set; } = null!;
        public string EmailaddressI { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
