using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00100
    {
        public string Techid { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Manager { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Pager1 { get; set; } = null!;
        public string Pin1 { get; set; } = null!;
        public string Pager2 { get; set; } = null!;
        public string Pin2 { get; set; } = null!;
        public string Techemail { get; set; } = null!;
        public string Techemail2 { get; set; } = null!;
        public byte Workdys1 { get; set; }
        public byte Workdys2 { get; set; }
        public byte Workdys3 { get; set; }
        public byte Workdys4 { get; set; }
        public byte Workdys5 { get; set; }
        public byte Workdys6 { get; set; }
        public byte Workdys7 { get; set; }
        public DateTime Workstrt1 { get; set; }
        public DateTime Workstrt2 { get; set; }
        public DateTime Workstrt3 { get; set; }
        public DateTime Workstrt4 { get; set; }
        public DateTime Workstrt5 { get; set; }
        public DateTime Workstrt6 { get; set; }
        public DateTime Workstrt7 { get; set; }
        public DateTime Workend1 { get; set; }
        public DateTime Workend2 { get; set; }
        public DateTime Workend3 { get; set; }
        public DateTime Workend4 { get; set; }
        public DateTime Workend5 { get; set; }
        public DateTime Workend6 { get; set; }
        public DateTime Workend7 { get; set; }
        public DateTime Dtehire { get; set; }
        public DateTime Dteterm { get; set; }
        public string Techstat { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Loccodeb { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Prclevel { get; set; } = null!;
        public string Ivrpassword { get; set; } = null!;
        public string Ivroptions { get; set; } = null!;
        public DateTime IvrloginDate { get; set; }
        public DateTime IvrpassDate { get; set; }
        public int Ivraccess { get; set; }
        public string Ivrgreet { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public byte SvcItemSiteDelta { get; set; }
        public DateTime SvcLastCommDate { get; set; }
        public int DexRowId { get; set; }
    }
}
