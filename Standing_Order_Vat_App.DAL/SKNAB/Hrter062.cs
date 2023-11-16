using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrter062
    {
        public string EmpidI { get; set; } = null!;
        public DateTime IdateI { get; set; }
        public short OpinionI { get; set; }
        public short JobsatisfactionI { get; set; }
        public short TrainingI { get; set; }
        public short PromotionI { get; set; }
        public short WagescaleI { get; set; }
        public short CompanybenifitsI { get; set; }
        public short WorkersI { get; set; }
        public short OrganizeI { get; set; }
        public short LeaderI { get; set; }
        public short FeedbackI { get; set; }
        public short CriticismI { get; set; }
        public short ConditionsI { get; set; }
        public short IhoursworkedI { get; set; }
        public string ChngimprovemntsI { get; set; } = null!;
        public string NewjobI { get; set; } = null!;
        public byte ConfidentialI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
