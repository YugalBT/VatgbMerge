using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm20202
    {
        public string Docnumbr { get; set; } = null!;
        public short Series { get; set; }
        public short Efttype { get; set; }
        public short EftfileFormat { get; set; }
        public DateTime Trxdate { get; set; }
        public decimal CheckbookAmount { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Isocurrc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchcomnt { get; set; } = null!;
        public string Paidtorcvdfrom { get; set; } = null!;
        public string Comment1 { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public DateTime Voiddate { get; set; }
        public string Audittrail { get; set; } = null!;
        public DateTime ExecDate { get; set; }
        public string RefNum { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short EftbankTypeCb { get; set; }
        public string EftbankAcctCb { get; set; } = null!;
        public string EftbankBranchCb { get; set; } = null!;
        public string EftbankCodeCb { get; set; } = null!;
        public string EftbankBranchCodeCb { get; set; } = null!;
        public string EftbankCheckDigitCb { get; set; } = null!;
        public string IntlBankAcctNum { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string CustomerVendorId { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public short EftbankType { get; set; }
        public string EftbankAcct { get; set; } = null!;
        public string EftbankBranch { get; set; } = null!;
        public string EftbankCode { get; set; } = null!;
        public string EftbankBranchCode { get; set; } = null!;
        public string EftbankCheckDigit { get; set; } = null!;
        public string CustVendIban { get; set; } = null!;
        public string Swiftaddr { get; set; } = null!;
        public string CustVendCountryCode { get; set; } = null!;
        public string DeliveryCountryCode { get; set; } = null!;
        public string Bnkctrcd { get; set; } = null!;
        public string Cbankcd { get; set; } = null!;
        public short GiropostType { get; set; }
        public string RegCode1 { get; set; } = null!;
        public string RegCode2 { get; set; } = null!;
        public short BankInfo1 { get; set; }
        public short BankInfo2 { get; set; }
        public short BankInfo3 { get; set; }
        public short BankInfo4 { get; set; }
        public short BankInfo5 { get; set; }
        public short BankInfo6 { get; set; }
        public short BankInfo7 { get; set; }
        public string FedResBankNum { get; set; } = null!;
        public string FedResClient { get; set; } = null!;
        public string FedResBranch { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
