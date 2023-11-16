using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00101
    {
        public string Chekbkid { get; set; } = null!;
        public short EftbankType { get; set; }
        public string AcctHolder { get; set; } = null!;
        public string EftbankAcct { get; set; } = null!;
        public string EftbankBranch { get; set; } = null!;
        public string EftbankCode { get; set; } = null!;
        public string EftbankBranchCode { get; set; } = null!;
        public string EftbankCheckDigit { get; set; } = null!;
        public string IntlBankAcctNum { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string DomPmtsFile { get; set; } = null!;
        public string ForeignPmtsFile { get; set; } = null!;
        public string DomDirDbtCollectFile { get; set; } = null!;
        public string DomDirDbtRefundFile { get; set; } = null!;
        public string BankIdnum { get; set; } = null!;
        public short BankInfo1 { get; set; }
        public short BankInfo2 { get; set; }
        public short BankInfo3 { get; set; }
        public short BankInfo4 { get; set; }
        public short BankInfo5 { get; set; }
        public short BankInfo6 { get; set; }
        public string FedResBankNum { get; set; } = null!;
        public string FedResClient { get; set; } = null!;
        public string FedResBranch { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
