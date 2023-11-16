using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2nj01
    {
        public string EmpidI { get; set; } = null!;
        public string InjurynumberI { get; set; } = null!;
        public DateTime IncidentdateI { get; set; }
        public string IncidenttimeI { get; set; } = null!;
        public DateTime NotifydateI { get; set; }
        public short GbillinjI { get; set; }
        public byte EmployeediedcbI { get; set; }
        public byte OsharecordableI { get; set; }
        public string O7sI { get; set; } = null!;
        public string InjurytypeI { get; set; } = null!;
        public string InjurybodypartI { get; set; } = null!;
        public string InjuryobjectcausinI { get; set; } = null!;
        public string InjurylocationI { get; set; } = null!;
        public byte OnsitecbI { get; set; }
        public string InjurytaskI { get; set; } = null!;
        public string PersonnotifiedI { get; set; } = null!;
        public string WitnessnameI { get; set; } = null!;
        public string WitnessaddressI { get; set; } = null!;
        public string WitnessphoneI { get; set; } = null!;
        public string TimearrivedI { get; set; } = null!;
        public DateTime DateofdeathI { get; set; }
        public DateTime DatereturnI { get; set; }
        public byte HospitalizedcbI { get; set; }
        public byte OutpatientI { get; set; }
        public byte EmergencyroomI { get; set; }
        public byte InhousetreatmentI { get; set; }
        public byte FirstaidI { get; set; }
        public byte SafeguardsprovdcbI { get; set; }
        public byte SafeguardsusedcbI { get; set; }
        public string SafeguarddescriptI { get; set; } = null!;
        public DateTime FirstaiddateI { get; set; }
        public string FirstaidnameI { get; set; } = null!;
        public string FirstaiddescriptI { get; set; } = null!;
        public string InjurydoctorI { get; set; } = null!;
        public string InjurydoctorphoneI { get; set; } = null!;
        public string InjurydoctorspeciaI { get; set; } = null!;
        public DateTime InjurydoctordatefiI { get; set; }
        public string InjurydoctortreatmI { get; set; } = null!;
        public string InjuryhospitalI { get; set; } = null!;
        public string InjuryhospitalphonI { get; set; } = null!;
        public short InjhosplengthofstaI { get; set; }
        public DateTime InjuryhospitaldateI { get; set; }
        public string InjuryhospitaltreaI { get; set; } = null!;
        public string ClaimnumberI { get; set; } = null!;
        public DateTime DatefiledI { get; set; }
        public DateTime DateclosedI { get; set; }
        public decimal DaysmissedI { get; set; }
        public decimal DaysrestrictedI { get; set; }
        public decimal DollartimelostI { get; set; }
        public decimal DollarmedicalcostI { get; set; }
        public string InjurycauseI { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public decimal Notesindex2I { get; set; }
        public decimal Notesindex3I { get; set; }
        public decimal Notesindex4I { get; set; }
        public decimal Notesindex5I { get; set; }
        public decimal Notesindex6I { get; set; }
        public byte ConfidentialI { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public DateTime DateCaseClosed { get; set; }
        public short CaseStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
