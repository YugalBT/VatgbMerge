using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class Cd
    {
        public string? AccountNumber { get; set; }
        public string? CurrentBalance { get; set; }
        public string? OriginalBalance { get; set; }
        public string? InterestLast { get; set; }
        public string? DateLastPaid { get; set; }
        public string? Term { get; set; }
        public string? TypeCode { get; set; }
        public string? ClassCode { get; set; }
        public string? RenewCode { get; set; }
        public string? InterestFreqCode { get; set; }
        public string? InterestRate { get; set; }
        public string? ApplyInterestCode { get; set; }
        public string? CorrespondingAcct { get; set; }
        public string? DateInterestNext { get; set; }
        public string? AmountIntere { get; set; }
        public string? MaturityDate { get; set; }
        public string? InterestPaid { get; set; }
        public string? AccruedInter { get; set; }
        public string? ForfeitAmount { get; set; }
        public string? Open { get; set; }
        public string? DailyAccruedInt { get; set; }
        public string? CompoundSimple { get; set; }
        public string? PrevMaturityDate { get; set; }
        public string? PrevInterestRate { get; set; }
        public string? RenewalBalance { get; set; }
        public string? MonthDayFlag { get; set; }
        public string? VariableRateNum { get; set; }
        public string? EarlyWDPenalty { get; set; }
        public string? UsCurrency { get; set; }
        public string? DaysYear { get; set; }
        public string? EoyInterest { get; set; }
        public string? OrigInterestRate { get; set; }
        public string? BalAtSplitRate { get; set; }
        public string? _158SplitVariableRate { get; set; }
        public string? VarAdjustToRate { get; set; }
        public string? VariableRateCode { get; set; }
        public string? DayInterestDue { get; set; }
        public string? EqualPayment { get; set; }
        public string? Reprint { get; set; }
        public string? QtdHighBalance { get; set; }
        public string? QtdInterest { get; set; }
        public string? EarlyWithPenalty { get; set; }
        public string? CheckAdviceNumber { get; set; }
        public string? AchRoutingNumber { get; set; }
        public string? AchTransacti { get; set; }
        public string? AchAccountNumber { get; set; }
        public string? MtdAggregateBal { get; set; }
        public string? JanAvgBal { get; set; }
        public string? FebAvgBal { get; set; }
        public string? MarAvgBal { get; set; }
        public string? AprAvgBal { get; set; }
        public string? MayAvgBal { get; set; }
        public string? JunAvgBal { get; set; }
        public string? JulAvgBal { get; set; }
        public string? AugAvgBal { get; set; }
        public string? SepAvgBal { get; set; }
        public string? OctAvgBal { get; set; }
        public string? NovAvgBal { get; set; }
        public string? DecAvgBal { get; set; }
        public string? PenaltyCode { get; set; }
        public string? ApyOfDigits { get; set; }
        public string? IntPtdAgg { get; set; }
        public string? ApyCurrentPeriod { get; set; }
        public string? TotalHoldAm { get; set; }
        public string? YtdAggregateBal { get; set; }
        public string? YtdAverageBalance { get; set; }
        public string? BeginningBalToday { get; set; }
        public string? _12MnthAverageBal { get; set; }
        public string? PendingAchTran { get; set; }
        public string? ThresholdGLCode { get; set; }
        public string? PriorYearIn { get; set; }
        public string? IntRateAtRedempt { get; set; }
        public string? RateCodeAt { get; set; }
        public string? NonTeaserRate { get; set; }
        public string? TeaserInt { get; set; }
        public string? TimesInterestPd { get; set; }
        public string? RenewalTerm { get; set; }
        public string? RenewalMoDayFlag { get; set; }
        public string? RenewalProductDef { get; set; }
        public string? RnwlTisDisclosure { get; set; }
        public string? RenewalClassCode { get; set; }
        public string? RnwlPenaltyCode { get; set; }
        public string? NxtRnwlPenaltyCd { get; set; }
        public string? MultipleNotices { get; set; }
        public int CdsId { get; set; }
    }
}
