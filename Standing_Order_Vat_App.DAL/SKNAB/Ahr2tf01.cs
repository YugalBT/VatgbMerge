using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2tf01
    {
        public string EmpidI { get; set; } = null!;
        public DateTime TransferrequestdatI { get; set; }
        public string DesiredcompanycodeI { get; set; } = null!;
        public string DesdivcodeI { get; set; } = null!;
        public string DesdeptcodeI { get; set; } = null!;
        public string DesposcodeI { get; set; } = null!;
        public string DessupcodeI { get; set; } = null!;
        public string DesloccodeI { get; set; } = null!;
        public short Employmenttype { get; set; }
        public string DesiredshiftcodeI { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
