using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rv010121
    {
        public string EmpidI { get; set; } = null!;
        public DateTime DateoflastreviewI { get; set; }
        public decimal ReviewratingdecimaI { get; set; }
        public string ReviewsetupcodeI { get; set; } = null!;
        public string ReviewsetupnameI { get; set; } = null!;
        public short ReviewrangeI { get; set; }
        public string ReviewedbyI { get; set; } = null!;
        public string ApprovedbyI { get; set; } = null!;
        public DateTime DateofnextreviewI { get; set; }
        public short EfficiencyI { get; set; }
        public decimal CostoferrorI { get; set; }
        public decimal CostofqualityI { get; set; }
        public decimal RecommendedwageI { get; set; }
        public DateTime EffectivedateI { get; set; }
        public byte ProbationI { get; set; }
        public short TotalweightI { get; set; }
        public string DesposcodeI { get; set; } = null!;
        public string ImprovementI { get; set; } = null!;
        public short SalperchangeI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public decimal Notesindex2I { get; set; }
        public decimal Notesindex3I { get; set; }
        public decimal Notesindex4I { get; set; }
        public short UsewordsgbI { get; set; }
        public int DexRowId { get; set; }
    }
}
