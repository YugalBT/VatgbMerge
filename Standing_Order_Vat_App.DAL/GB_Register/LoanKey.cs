using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class LoanKey
    {
        public string? ACType { get; set; }
        public double? FldNum { get; set; }
        public double? FldLen { get; set; }
        public string? AD { get; set; }
        public double? Chg { get; set; }
        public double? Upd { get; set; }
        public double? Inq { get; set; }
        public double? _1stMastLoc { get; set; }
        public double? LastLocation { get; set; }
        public double? LmtCod { get; set; }
        public double? GLCol { get; set; }
        public string? CrDb { get; set; }
        public string? GlClrFlg { get; set; }
        public string? Lc { get; set; }
        public string? Usr { get; set; }
        public string? FieldDescription { get; set; }
        public string? HelpDescription { get; set; }
    }
}
