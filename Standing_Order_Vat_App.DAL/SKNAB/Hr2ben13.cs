using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben13
    {
        public string Benefit { get; set; } = null!;
        public short AgerangeI { get; set; }
        public decimal PremiumemployeeI { get; set; }
        public decimal PremiumsmokerI { get; set; }
        public decimal PremiumspouseI { get; set; }
        public decimal PremsmokespouseI { get; set; }
        public int DexRowId { get; set; }
    }
}
