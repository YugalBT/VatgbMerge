using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahrin022
    {
        public string InjurynumberI { get; set; } = null!;
        public string IserialnumberI { get; set; } = null!;
        public string EmpidI { get; set; } = null!;
        public decimal CliniccostsI { get; set; }
        public decimal DoctorcostsI { get; set; }
        public decimal MedicationcostsI { get; set; }
        public decimal OthercostsI { get; set; }
        public decimal TestcostsI { get; set; }
        public decimal TherapycostsI { get; set; }
        public decimal TotalcostsI { get; set; }
        public string Cmnts1I { get; set; } = null!;
        public string Cmnts2I { get; set; } = null!;
        public string Cmnts3I { get; set; } = null!;
        public string Cmnts4I { get; set; } = null!;
        public DateTime IdateI { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
