using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142806
    {
        public string Arnum { get; set; } = null!;
        public string Meardlid { get; set; } = null!;
        public DateTime MeDownloadDate { get; set; }
        public DateTime MeDownloadTime { get; set; }
        public DateTime Mklsstdd { get; set; }
        public DateTime Meldtdt { get; set; }
        public string MeConfirmationNumber { get; set; } = null!;
        public short Menumdlds { get; set; }
        public DateTime MeCuttoffDate { get; set; }
        public DateTime MeBeginDate { get; set; }
        public DateTime MeEndDate { get; set; }
        public short MeNumberOfChecks { get; set; }
        public decimal MeChecksAmount { get; set; }
        public short MeNumberOfDeps { get; set; }
        public decimal MeDepsAmount { get; set; }
        public decimal MeOthersAmount { get; set; }
        public short MeNumberOfOther { get; set; }
        public short MeNumberOfCredits { get; set; }
        public short MeNumberOfDebits { get; set; }
        public decimal MeCreditsTotal { get; set; }
        public decimal MeDebitsTotal { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
