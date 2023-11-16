using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr24be17
    {
        public string EmpidI { get; set; } = null!;
        public DateTime Bnfbegdt { get; set; }
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public string BeneficiaryprimaryI { get; set; } = null!;
        public string BencontingentI { get; set; } = null!;
        public string Namea15I { get; set; } = null!;
        public string Nameb15I { get; set; } = null!;
        public string Namea50I { get; set; } = null!;
        public short AgeemployeeI { get; set; }
        public short AgespouseI { get; set; }
        public short ChildrenI { get; set; }
        public decimal LifeamtmaxI { get; set; }
        public decimal LifeamtmaxspouseI { get; set; }
        public decimal LifeamtmaxchildI { get; set; }
        public decimal NearestI { get; set; }
        public decimal NearestspouseI { get; set; }
        public decimal NearestchildI { get; set; }
        public short Bnftfreq { get; set; }
        public byte SmokerI { get; set; }
        public byte SmokerspI { get; set; }
        public short GbI { get; set; }
        public decimal NearestemployerI { get; set; }
        public decimal PremiumemployerI { get; set; }
        public decimal PremiumemployeeI { get; set; }
        public decimal PremiumsmokerI { get; set; }
        public decimal PremiumspouseI { get; set; }
        public decimal PremsmokespouseI { get; set; }
        public decimal PremiumchildI { get; set; }
        public int DexRowId { get; set; }
    }
}
