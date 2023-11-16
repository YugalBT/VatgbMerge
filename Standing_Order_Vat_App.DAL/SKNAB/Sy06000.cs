using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy06000
    {
        public short Series { get; set; }
        public string CustomerVendorId { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public short EftbankType { get; set; }
        public byte Frgnbank { get; set; }
        public byte Inactive { get; set; }
        public string Bankname { get; set; } = null!;
        public string EftbankAcct { get; set; } = null!;
        public string EftbankBranch { get; set; } = null!;
        public short GiropostType { get; set; }
        public string EftbankCode { get; set; } = null!;
        public string EftbankBranchCode { get; set; } = null!;
        public string EftbankCheckDigit { get; set; } = null!;
        public string Bsrollno { get; set; } = null!;
        public string IntlBankAcctNum { get; set; } = null!;
        public string Swiftaddr { get; set; } = null!;
        public string CustVendCountryCode { get; set; } = null!;
        public string DeliveryCountryCode { get; set; } = null!;
        public string Bnkctrcd { get; set; } = null!;
        public string Cbankcd { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Address4 { get; set; } = null!;
        public string RegCode1 { get; set; } = null!;
        public string RegCode2 { get; set; } = null!;
        public short BankInfo7 { get; set; }
        public int DexRowId { get; set; }
    }
}
