using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr70500
    {
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public byte Askechtm { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public string Rnge { get; set; } = null!;
        public string SortbyI { get; set; } = null!;
        public short SortbynumberI { get; set; }
        public short SortoptionI { get; set; }
        public string FromissnI { get; set; } = null!;
        public string ToissnI { get; set; } = null!;
        public string FromfirstnameI { get; set; } = null!;
        public string FromlastnameI { get; set; } = null!;
        public string TofirstnameI { get; set; } = null!;
        public string TolastnameI { get; set; } = null!;
        public string CompanycodeI { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public string DepartmentcodeI { get; set; } = null!;
        public string PositioncodeI { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public string FromemployeeidI { get; set; } = null!;
        public string ToemployeeidI { get; set; } = null!;
        public DateTime FromdateI { get; set; }
        public DateTime TodateI { get; set; }
        public short Hrstatus { get; set; }
        public short Employmenttype { get; set; }
        public byte Incinemp { get; set; }
        public DateTime Dateending { get; set; }
        public string SkillsetI { get; set; } = null!;
        public int RequisitionnumberI { get; set; }
        public string FromtestcodeI { get; set; } = null!;
        public string TotestcodeI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public string CourseidI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
