using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Attendancetest
    {
        public int IdEmployee { get; set; }
        public int? NmSpecialDays { get; set; }
        public int? NmAppvdAb { get; set; }
        public int? NmUnAppvdAb { get; set; }
        public DateTime? DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public DateTime? DtInformed { get; set; }
        public DateTime? TmInformed { get; set; }
        public string? TxInformedBy { get; set; }
        public string? TxReasons { get; set; }
        public string? TxMemo { get; set; }
        public string? TxGmrec { get; set; }
        public bool? InTdAm { get; set; }
        public bool? InTdPm { get; set; }
        public bool? InAppvd { get; set; }
        public bool? InNtappvd { get; set; }
        public bool? InTobeAppvd { get; set; }
        public string InDelFlg { get; set; } = null!;
        public int Key { get; set; }
        public int? IdMonth { get; set; }
        public int? NmInterval { get; set; }
        public DateTime? DtMod { get; set; }
        public string? NmModBy { get; set; }
        public int? SocialSecurity { get; set; }
    }
}
