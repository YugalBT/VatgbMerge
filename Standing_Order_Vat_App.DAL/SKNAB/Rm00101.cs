using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00101
    {
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Custclas { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Stmtname { get; set; } = null!;
        public string Shrtname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Upszone { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public string Prbtadcd { get; set; } = null!;
        public string Prstadcd { get; set; } = null!;
        public string Staddrcd { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public short Crlmttyp { get; set; }
        public decimal Crlmtamt { get; set; }
        public short Crlmtper { get; set; }
        public decimal Crlmtpam { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public short Custdisc { get; set; }
        public string Prclevel { get; set; } = null!;
        public short Minpytyp { get; set; }
        public decimal Minpydlr { get; set; }
        public short Minpypct { get; set; }
        public short Fnchatyp { get; set; }
        public short Fnchpcnt { get; set; }
        public decimal Finchdlr { get; set; }
        public short Mxwoftyp { get; set; }
        public decimal Mxwrofam { get; set; }
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Taxexmt1 { get; set; } = null!;
        public string Taxexmt2 { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public short Balnctyp { get; set; }
        public short Stmtcycl { get; set; }
        public string Bankname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Defcacty { get; set; }
        public int Rmcshacc { get; set; }
        public int Rmaracc { get; set; }
        public int Rmslsacc { get; set; }
        public int Rmivacc { get; set; }
        public int Rmcosacc { get; set; }
        public int Rmtakacc { get; set; }
        public int Rmavacc { get; set; }
        public int Rmfcgacc { get; set; }
        public int Rmwracc { get; set; }
        public int Rmsoracc { get; set; }
        public DateTime Frstindt { get; set; }
        public byte Inactive { get; set; }
        public byte Hold { get; set; }
        public string Crcardid { get; set; } = null!;
        public string Crcrdnum { get; set; } = null!;
        public DateTime Ccrdxpdt { get; set; }
        public byte Kpdsthst { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public byte RevalueCustomer { get; set; }
        public short PostResultsTo { get; set; }
        public string Finchid { get; set; } = null!;
        public string Govcrpid { get; set; } = null!;
        public string Govindid { get; set; } = null!;
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public string Docfmtid { get; set; } = null!;
        public byte SendEmailStatements { get; set; }
        public short Userlang { get; set; }
        public string Gpsfointegrationid { get; set; } = null!;
        public short Integrationsource { get; set; }
        public string Integrationid { get; set; } = null!;
        public short Orderfulfilldefault { get; set; }
        public short Custpriority { get; set; }
        public string Ccode { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public int RmovrpymtWrtoffAcctIdx { get; set; }
        public byte Shipcomplete { get; set; }
        public byte Cbvat { get; set; }
        public byte Includeindp { get; set; }
        public int DexRowId { get; set; }

        public virtual Rm00105 Rm00105 { get; set; } = null!;
    }
}
