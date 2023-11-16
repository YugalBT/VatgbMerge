using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class ReportSchedule
    {
        public short Rptgrind { get; set; }
        public short Prodid { get; set; }
        public short Rtpachin { get; set; }
        public short Rtcfgwin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public string Rptgrnms { get; set; } = null!;
        public string BusinessDeskReportNam { get; set; } = null!;
        public string BusinessDeskReportTyp { get; set; } = null!;
        public string ReportUrl { get; set; } = null!;
        public short PublishFrequency { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Strttime { get; set; }
        public short Nmbrofdys { get; set; }
        public short DailyFrequencyOptions { get; set; }
        public short WeeklyFrequencyOptions { get; set; }
        public short MonthlyFrequencyOptions { get; set; }
        public byte ScheduledDaysOfTheWeek1 { get; set; }
        public byte ScheduledDaysOfTheWeek2 { get; set; }
        public byte ScheduledDaysOfTheWeek3 { get; set; }
        public byte ScheduledDaysOfTheWeek4 { get; set; }
        public byte ScheduledDaysOfTheWeek5 { get; set; }
        public byte ScheduledDaysOfTheWeek6 { get; set; }
        public byte ScheduledDaysOfTheWeek7 { get; set; }
        public short ScheduledDayOfTheWeek { get; set; }
        public short ScheduledWeekOfTheMo { get; set; }
        public short Dayofmonth { get; set; }
        public byte ScheduledMonthOfTheYear1 { get; set; }
        public byte ScheduledMonthOfTheYear2 { get; set; }
        public byte ScheduledMonthOfTheYear3 { get; set; }
        public byte ScheduledMonthOfTheYear4 { get; set; }
        public byte ScheduledMonthOfTheYear5 { get; set; }
        public byte ScheduledMonthOfTheYear6 { get; set; }
        public byte ScheduledMonthOfTheYear7 { get; set; }
        public byte ScheduledMonthOfTheYear8 { get; set; }
        public byte ScheduledMonthOfTheYear9 { get; set; }
        public byte ScheduledMonthOfTheYear10 { get; set; }
        public byte ScheduledMonthOfTheYear11 { get; set; }
        public byte ScheduledMonthOfTheYear12 { get; set; }
        public short NumberOfWeeks { get; set; }
        public DateTime LastDatePublished { get; set; }
        public DateTime LastTimePublished { get; set; }
        public DateTime NextDayToPublish { get; set; }
        public DateTime NextTimeToPublish { get; set; }
        public string GenerateReportScript { get; set; } = null!;
        public string OpenReportOptionWindowSc { get; set; } = null!;
        public short KeepPriorVersions { get; set; }
        public int DexRowId { get; set; }
    }
}
