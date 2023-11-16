using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrdep022
    {
        public string DepartmentcodeI { get; set; } = null!;
        public DateTime DatesI1 { get; set; }
        public DateTime DatesI2 { get; set; }
        public DateTime DatesI3 { get; set; }
        public DateTime DatesI4 { get; set; }
        public DateTime DatesI5 { get; set; }
        public string StringsI1 { get; set; } = null!;
        public string StringsI2 { get; set; } = null!;
        public string StringsI3 { get; set; } = null!;
        public string StringsI4 { get; set; } = null!;
        public string StringsI5 { get; set; } = null!;
        public int Numericextra1 { get; set; }
        public int Numericextra2 { get; set; }
        public int Numericextra3 { get; set; }
        public int Numericextra4 { get; set; }
        public int Numericextra5 { get; set; }
        public decimal DollarsI1 { get; set; }
        public decimal DollarsI2 { get; set; }
        public decimal DollarsI3 { get; set; }
        public decimal DollarsI4 { get; set; }
        public decimal DollarsI5 { get; set; }
        public byte CheckboxesI1 { get; set; }
        public byte CheckboxesI2 { get; set; }
        public byte CheckboxesI3 { get; set; }
        public byte CheckboxesI4 { get; set; }
        public byte CheckboxesI5 { get; set; }
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
