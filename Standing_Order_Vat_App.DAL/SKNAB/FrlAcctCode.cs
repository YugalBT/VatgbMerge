using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class FrlAcctCode
    {
        public decimal AcctId { get; set; }
        public short EntityNum { get; set; }
        public string AcctCode { get; set; } = null!;
        public short? AcctType { get; set; }
        public byte AcctStatus { get; set; }
        public string AcctDesc { get; set; } = null!;
        public byte NormalBal { get; set; }
        public short AcctGroup { get; set; }
        public string? NatSegCode { get; set; }
        public byte? RollupLevel { get; set; }
        public DateTime? ActivatedDate { get; set; }
        public DateTime? LastUsedDate { get; set; }
        public DateTime? DeactivatedDate { get; set; }
        public byte? ModifyFlag { get; set; }
    }
}
