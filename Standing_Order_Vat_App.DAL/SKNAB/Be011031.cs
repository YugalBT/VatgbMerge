using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Be011031
    {
        public string EmpidI { get; set; } = null!;
        public short Index1 { get; set; }
        public DateTime CalendarstartI { get; set; }
        public DateTime AbsencestartdateI { get; set; }
        public DateTime AbsenceenddateI { get; set; }
        public DateTime Bnfbegdt { get; set; }
        public DateTime Bnfenddt { get; set; }
        public DateTime EstreturndateI { get; set; }
        public DateTime PhyprovnotifiedI { get; set; }
        public byte LeaveapprovalI { get; set; }
        public DateTime BenefitexpireI { get; set; }
        public short IbenefitfrequencyI { get; set; }
        public decimal IbenefitamountI { get; set; }
        public decimal IbenefityearmaxI { get; set; }
        public byte Check1I { get; set; }
        public decimal HoursworkedperdayI { get; set; }
        public short TypeofdayI { get; set; }
        public byte Check2I { get; set; }
        public DateTime IdateI { get; set; }
        public DateTime Oldcalendarstartfmla { get; set; }
        public int DexRowId { get; set; }
        public string CommentsI { get; set; } = null!;
    }
}
