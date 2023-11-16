using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc10000
    {
        public string Rvlueid { get; set; } = null!;
        public short Rvlsries { get; set; }
        public short Rvluoptn { get; set; }
        public short Gainloss { get; set; }
        public DateTime Trxdate { get; set; }
        public byte Revsetrx { get; set; }
        public DateTime Rvrsngdt { get; set; }
        public short Rvluyrop { get; set; }
        public short Year1 { get; set; }
        public short Rvlupdop { get; set; }
        public short Periodid { get; set; }
        public short Rvlurtop { get; set; }
        public short Sortby { get; set; }
        public byte Incldpar { get; set; }
        public byte IncludeInvoice { get; set; }
        public byte IncludeDebitMemo { get; set; }
        public byte IncludeFinanceCharge { get; set; }
        public byte IncludeServiceRepair { get; set; }
        public byte IncludeCreditMemo { get; set; }
        public byte IncludeReturn { get; set; }
        public byte IncludeCashReceipt { get; set; }
        public byte IncludeMiscCharge { get; set; }
        public byte IncludePayment { get; set; }
        public string Sttacnum1 { get; set; } = null!;
        public string Sttacnum2 { get; set; } = null!;
        public string Sttacnum3 { get; set; } = null!;
        public string Sttacnum4 { get; set; } = null!;
        public string Sttacnum5 { get; set; } = null!;
        public string Sttacnum6 { get; set; } = null!;
        public string Sttacnum7 { get; set; } = null!;
        public string Sttacnum8 { get; set; } = null!;
        public string Sttacnum9 { get; set; } = null!;
        public string Sttacnum10 { get; set; } = null!;
        public string Eaccnbr1 { get; set; } = null!;
        public string Eaccnbr2 { get; set; } = null!;
        public string Eaccnbr3 { get; set; } = null!;
        public string Eaccnbr4 { get; set; } = null!;
        public string Eaccnbr5 { get; set; } = null!;
        public string Eaccnbr6 { get; set; } = null!;
        public string Eaccnbr7 { get; set; } = null!;
        public string Eaccnbr8 { get; set; } = null!;
        public string Eaccnbr9 { get; set; } = null!;
        public string Eaccnbr10 { get; set; } = null!;
        public string Sttclsid { get; set; } = null!;
        public string Endclsid { get; set; } = null!;
        public string Sttudef1 { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public string StartCustOrVendId { get; set; } = null!;
        public string EndCustOrVendId { get; set; } = null!;
        public DateTime Cutofdat { get; set; }
        public byte[] Mcrvalhdrmsgs { get; set; } = null!;
        public byte LimitDocumentGains { get; set; }
        public int DexRowId { get; set; }
    }
}
