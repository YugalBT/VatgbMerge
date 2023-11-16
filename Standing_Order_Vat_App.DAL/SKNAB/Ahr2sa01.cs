using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahr2sa01
    {
        public string EmpidI { get; set; } = null!;
        public DateTime EffectivedateI { get; set; }
        public decimal WageI { get; set; }
        public short CompensationperiodI { get; set; }
        public string ChangereasonI { get; set; } = null!;
        public decimal Shftprem { get; set; }
        public decimal AnnualsalaryI { get; set; }
        public decimal PthoursI { get; set; }
        public decimal NotesindexI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public int DexRowId { get; set; }
    }
}
