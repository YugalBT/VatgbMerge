using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwPayslip
    {
        public int PaymentId { get; set; }
        public int EmployeeId { get; set; }
        public string? FullName { get; set; }
        public DateTime PayBegin { get; set; }
        public DateTime PayEnd { get; set; }
        public decimal RegularPay { get; set; }
        public decimal GrossPay { get; set; }
        public decimal OvertimePay { get; set; }
        public decimal Adjustments { get; set; }
        public decimal ActualPay { get; set; }
        public decimal Ssemployee { get; set; }
        public decimal Slemployee { get; set; }
        public decimal Ssemployer { get; set; }
        public decimal Slemployer { get; set; }
        public decimal SsemployerInj { get; set; }
        public decimal SlemployerSev { get; set; }
        public string? Paid { get; set; }
        public string? SentToSsb { get; set; }
        public DateTime LastModified { get; set; }
        public string? IsOverride { get; set; }
        public int PayCycle { get; set; }
        public int GroupId { get; set; }
        public int? Ssn { get; set; }
        public decimal? YtdgrossPay { get; set; }
        public decimal? Ytdssemployee { get; set; }
        public decimal? Ytdslemployee { get; set; }
        public DateTime? PayDate { get; set; }
        public int? RegularExpsGl { get; set; }
        public int? RegularGl { get; set; }
        public int? SsemployeeGl { get; set; }
        public int? SlemployeeGl { get; set; }
        public int? SsemployerGl { get; set; }
        public int? SsemployerExpsGl { get; set; }
        public int? SlemployerGl { get; set; }
        public int? SlemployerExpsGl { get; set; }
        public int? OvertimeGl { get; set; }
        public int CompanyId { get; set; }
        public string? PayTypeName { get; set; }
        public int? TypeId { get; set; }
        public int? IdHistory { get; set; }
    }
}
