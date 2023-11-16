using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cpo40001
    {
        public short Cmpanyid { get; set; }
        public byte CommitmentApproval { get; set; }
        public byte TrackCommitment { get; set; }
        public string Budpwrd { get; set; } = null!;
        public short ApprovalType { get; set; }
        public byte ApprovalVariance { get; set; }
        public short ApprovalVarianceType { get; set; }
        public decimal VarianceAmount { get; set; }
        public decimal CpopVariancePercentage { get; set; }
        public string ApprovalPassword { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
