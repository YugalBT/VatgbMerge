using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2em02
    {
        public string EmpidI { get; set; } = null!;
        public DateTime EffectivedateI { get; set; }
        public string CompanyI { get; set; } = null!;
        public string DivisionI { get; set; } = null!;
        public string DepartmentnameI { get; set; } = null!;
        public string PositionI { get; set; } = null!;
        public short Employmenttype { get; set; }
        public short Hrstatus { get; set; }
        public short SeparationreasonI { get; set; }
        public string Shftcode { get; set; } = null!;
        public string Rsnempin { get; set; } = null!;
        public string Supervisor { get; set; } = null!;
        public string LocationI { get; set; } = null!;
        public string ChangereasonI { get; set; } = null!;
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
