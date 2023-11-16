using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2skl04
    {
        public string EmpidI { get; set; } = null!;
        public int SkillsetnumberI { get; set; }
        public short PctcertifiedI { get; set; }
        public short PctcompletedI { get; set; }
        public short NumberpossessedI { get; set; }
        public int DexRowId { get; set; }
    }
}
