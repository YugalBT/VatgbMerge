using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd019
    {
        public string Pmtdocid { get; set; } = null!;
        public string PmntDocDescription { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public byte PayableBeforeDueDate { get; set; }
        public decimal Noteindx { get; set; }
        public string Usrstrg1 { get; set; } = null!;
        public string Usrstrg2 { get; set; } = null!;
        public string Usrstrg3 { get; set; } = null!;
        public string Usrstrg4 { get; set; } = null!;
        public string Usrstrg5 { get; set; } = null!;
        public string Usrstrg6 { get; set; } = null!;
        public string Usrdate1 { get; set; } = null!;
        public string Usrdate2 { get; set; } = null!;
        public string Usrcurr1 { get; set; } = null!;
        public string Usrcurr2 { get; set; } = null!;
        public string Usrbact1 { get; set; } = null!;
        public string Usrbact2 { get; set; } = null!;
        public byte ReqUserDefnStr1 { get; set; }
        public byte ReqUserDefnStr2 { get; set; }
        public byte ReqUserDefnStr3 { get; set; }
        public byte ReqUserDefnStr4 { get; set; }
        public byte ReqUserDefnStr5 { get; set; }
        public byte ReqUserDefnStr6 { get; set; }
        public byte ReqUserDefnDate1 { get; set; }
        public byte ReqUserDefnDate2 { get; set; }
        public byte ReqUserDefnCurr1 { get; set; }
        public byte ReqUserDefnCurr2 { get; set; }
        public byte ReqUserDefnBankAcct1 { get; set; }
        public byte ReqUserDefnBankAcct2 { get; set; }
        public int DexRowId { get; set; }
    }
}
