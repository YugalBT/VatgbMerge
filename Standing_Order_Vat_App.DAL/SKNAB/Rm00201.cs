using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00201
    {
        public string Classid { get; set; } = null!;
        public string Clasdscr { get; set; } = null!;
        public short Crlmttyp { get; set; }
        public decimal Crlmtamt { get; set; }
        public short Crlmtper { get; set; }
        public decimal Crlmtpam { get; set; }
        public byte Defltcls { get; set; }
        public short Balnctyp { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public short Custdisc { get; set; }
        public string Cstprlvl { get; set; } = null!;
        public short Minpytyp { get; set; }
        public decimal Minpydlr { get; set; }
        public short Minpypct { get; set; }
        public short Mxwoftyp { get; set; }
        public decimal Mxwrofam { get; set; }
        public byte Fincharg { get; set; }
        public short Fnchatyp { get; set; }
        public decimal Finchdlr { get; set; }
        public short Fnchpcnt { get; set; }
        public string Prclevel { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public short Defcacty { get; set; }
        public int Rmcshacc { get; set; }
        public int Rmaracc { get; set; }
        public int Rmcosacc { get; set; }
        public int Rmivacc { get; set; }
        public int Rmslsacc { get; set; }
        public int Rmavacc { get; set; }
        public int Rmtakacc { get; set; }
        public int Rmfcgacc { get; set; }
        public int Rmwracc { get; set; }
        public int Rmsoracc { get; set; }
        public string Salsterr { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public short Stmtcycl { get; set; }
        public byte Sndstmnt { get; set; }
        public byte Inactive { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kpdsthst { get; set; }
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public byte RevalueCustomer { get; set; }
        public short PostResultsTo { get; set; }
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public short Orderfulfilldefault { get; set; }
        public short Custpriority { get; set; }
        public int RmovrpymtWrtoffAcctIdx { get; set; }
        public byte Cbvat { get; set; }
        public byte Includeindp { get; set; }
        public int DexRowId { get; set; }
    }
}
