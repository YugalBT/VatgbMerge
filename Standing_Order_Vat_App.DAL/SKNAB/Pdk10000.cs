using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk10000
    {
        public short PdkTimesheetTrxType { get; set; }
        public string PdkTsNo { get; set; } = null!;
        public string PdkRefDocNo { get; set; } = null!;
        public short PdkDocumentStatus { get; set; }
        public short PdkTrxSource { get; set; }
        public byte PdkRemoteChange { get; set; }
        public DateTime Padocdt { get; set; }
        public short Payr { get; set; }
        public string Employid { get; set; } = null!;
        public short Parepd { get; set; }
        public short PaEmployedBy { get; set; }
        public DateTime Parepdt { get; set; }
        public DateTime PaperiodEndDate { get; set; }
        public string Pacomm { get; set; } = null!;
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public decimal PdkTotalQuantity { get; set; }
        public decimal Patotcosts { get; set; }
        public decimal Patacrv { get; set; }
        public string Noteid { get; set; } = null!;
        public string PdkReportingSuffix { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Manager { get; set; } = null!;
        public short ManagerApprovalStatus { get; set; }
        public string Supervisor { get; set; } = null!;
        public short SupApprovalStatus { get; set; }
        public string Administrator { get; set; } = null!;
        public short AdminApprovalStatus { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Paorigtotcosts { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public string Patsno { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public string PdkProxyId { get; set; } = null!;
        public short PdkTsAppUpdate { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public int DexRowId { get; set; }
    }
}
