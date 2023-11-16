using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hrori012
    {
        public string EmpidI { get; set; } = null!;
        public string MaidennameI { get; set; } = null!;
        public byte I9alienuntilcbI { get; set; }
        public byte I9citizencbI { get; set; }
        public byte I9lpresidentI { get; set; }
        public DateTime IstartdateI { get; set; }
        public string DocumentA1I { get; set; } = null!;
        public string DocumentA2I { get; set; } = null!;
        public string DocumentBI { get; set; } = null!;
        public string DocumentCI { get; set; } = null!;
        public string DocumenttitleaI { get; set; } = null!;
        public string DocumenttitlebI { get; set; } = null!;
        public string DocumenttitlecI { get; set; } = null!;
        public DateTime Expirationa1I { get; set; }
        public DateTime Expirationa2I { get; set; }
        public DateTime ExpirationbI { get; set; }
        public DateTime ExpirationcI { get; set; }
        public string IssueauthorityaI { get; set; } = null!;
        public string IssueauthoritybI { get; set; } = null!;
        public string IssueauthoritycI { get; set; } = null!;
        public string AlienadminnumberI { get; set; } = null!;
        public string AliennumberI { get; set; } = null!;
        public DateTime AlienuntildateI { get; set; }
        public DateTime DatefiledI { get; set; }
        public string PreparersnameI { get; set; } = null!;
        public string PrepareraddressI { get; set; } = null!;
        public DateTime DateinI { get; set; }
        public string EmployernameI { get; set; } = null!;
        public string Title1I { get; set; } = null!;
        public string Title2I { get; set; } = null!;
        public string BusnameaddrI { get; set; } = null!;
        public string NewnameI { get; set; } = null!;
        public DateTime RehiredateI { get; set; }
        public DateTime O3cdateexpireI { get; set; }
        public string O3cdocuI { get; set; } = null!;
        public string O3cdocutitleI { get; set; } = null!;
        public DateTime DatesignedI { get; set; }
        public DateTime DateoflastchangeI { get; set; }
        public DateTime Exitdate { get; set; }
        public DateTime Reentrydate { get; set; }
        public int DexRowId { get; set; }
    }
}
