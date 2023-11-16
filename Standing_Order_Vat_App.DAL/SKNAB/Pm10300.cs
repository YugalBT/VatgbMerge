using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm10300
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Pmntnmbr { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Appldamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Chektotl { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Comment1 { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Vndchknm { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public decimal Distknam { get; set; }
        public decimal Disamtav { get; set; }
        public decimal Wrofamnt { get; set; }
        public string Curncyid { get; set; } = null!;
        public byte Voided { get; set; }
        public short Reprnted { get; set; }
        public decimal Gstdsamt { get; set; }
        public short Pgramsbj { get; set; }
        public short Ppstaxrt { get; set; }
        public decimal Ppsamded { get; set; }
        public short Ldocrmtc { get; set; }
        public short Sdormby { get; set; }
        public string Keyfield { get; set; } = null!;
        public string Amwdsnbr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public short Doctype { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public short Pstgstus { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public byte[] Pmwrkmsg { get; set; } = null!;
        public byte[] Pmwrkms2 { get; set; } = null!;
        public byte[] Pmdstmsg { get; set; } = null!;
        public string Chkcomnt { get; set; } = null!;
        public DateTime Pstgdate { get; set; }
        public string Strga255 { get; set; } = null!;
        public string Strgb255 { get; set; } = null!;
        public byte Seprmtnc { get; set; }
        public byte Stbovrfl { get; set; }
        public string Ctystzip { get; set; } = null!;
        public decimal TotDocAmt { get; set; }
        public decimal TotAmtPaid { get; set; }
        public decimal TotCrdAmt { get; set; }
        public decimal TotalPaidTot { get; set; }
        public decimal TotNegTot { get; set; }
        public decimal TotCrdDocAmt { get; set; }
        public decimal TotTotDocAmt { get; set; }
        public decimal TotDiscTknAmt { get; set; }
        public decimal TotWoamt { get; set; }
        public decimal TotPpsamtDed { get; set; }
        public decimal TotGstdiscAmt { get; set; }
        public decimal TotDiscTknTot { get; set; }
        public decimal TotWotot { get; set; }
        public decimal OutstandingAmount { get; set; }
        public decimal NetPaidAmount { get; set; }
        public byte Electronic { get; set; }
        public int DexRowId { get; set; }
        public string Amtinwds { get; set; } = null!;
    }
}
