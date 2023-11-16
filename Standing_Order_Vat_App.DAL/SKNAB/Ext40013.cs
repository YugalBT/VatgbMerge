using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40013
    {
        public short ExtenderType { get; set; }
        public string ExtenderId { get; set; } = null!;
        public short WindowNumber { get; set; }
        public short FieldNumber { get; set; }
        public int Lnitmseq { get; set; }
        public int ConditionFields1 { get; set; }
        public int ConditionFields2 { get; set; }
        public int ConditionFields3 { get; set; }
        public int ConditionFields4 { get; set; }
        public short CondCompareType1 { get; set; }
        public short CondCompareType2 { get; set; }
        public short CondCompareType3 { get; set; }
        public short CondCompareType4 { get; set; }
        public short ConditionRestrictionType1 { get; set; }
        public short ConditionRestrictionType2 { get; set; }
        public short ConditionRestrictionType3 { get; set; }
        public short ConditionRestrictionType4 { get; set; }
        public int ConditionCompareFields1 { get; set; }
        public int ConditionCompareFields2 { get; set; }
        public int ConditionCompareFields3 { get; set; }
        public int ConditionCompareFields4 { get; set; }
        public string ConditionCompareConstant1 { get; set; } = null!;
        public string ConditionCompareConstant2 { get; set; } = null!;
        public string ConditionCompareConstant3 { get; set; } = null!;
        public string ConditionCompareConstant4 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Txtfield { get; set; } = null!;
    }
}
