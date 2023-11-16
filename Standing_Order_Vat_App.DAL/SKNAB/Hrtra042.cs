using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrtra042
    {
        public string CourseidI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public short SkillnumberI { get; set; }
        public int DexRowId { get; set; }
    }
}
