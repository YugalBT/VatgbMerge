using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40100
    {
        public string Commntid { get; set; } = null!;
        public short Setupkey { get; set; }
        public byte Dpyitmcs { get; set; }
        public byte Dqtyswar { get; set; }
        public byte Trkvdtrx { get; set; }
        public byte Calckitc { get; set; }
        public byte Newrates { get; set; }
        public byte Trmstnum { get; set; }
        public int Nxtmstno { get; set; }
        public byte Quote { get; set; }
        public byte Prder { get; set; }
        public byte Invoretu { get; set; }
        public byte Acdstrbn { get; set; }
        public string Locncode { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short Dfqtysop { get; set; }
        public string Quodocid { get; set; } = null!;
        public string Orddocid { get; set; } = null!;
        public string Bacdocid { get; set; } = null!;
        public string Invdocid { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Useacfrm { get; set; }
        public short Useadvtx { get; set; }
        public string Taxschid { get; set; } = null!;
        public short Nonivtxb { get; set; }
        public string Nonivsch { get; set; } = null!;
        public short Frgttxbl { get; set; }
        public string Frtschid { get; set; } = null!;
        public short Misctxbl { get; set; }
        public string Mscschid { get; set; } = null!;
        public short Mpackslp { get; set; }
        public short Mpicktic { get; set; }
        public short PriceLevelWarning { get; set; }
        public byte Sopallow1 { get; set; }
        public byte Sopallow2 { get; set; }
        public byte Sopallow3 { get; set; }
        public byte Sopallow4 { get; set; }
        public byte Sopallow5 { get; set; }
        public byte Sopallow6 { get; set; }
        public byte Sopallow7 { get; set; }
        public byte Sopallow8 { get; set; }
        public byte Sopallow9 { get; set; }
        public byte Sopallow10 { get; set; }
        public string Soppsswd1 { get; set; } = null!;
        public string Soppsswd2 { get; set; } = null!;
        public string Soppsswd3 { get; set; } = null!;
        public string Soppsswd4 { get; set; } = null!;
        public string Soppsswd5 { get; set; } = null!;
        public string Soppsswd6 { get; set; } = null!;
        public string Soppsswd7 { get; set; } = null!;
        public string Soppsswd8 { get; set; } = null!;
        public string Soppsswd9 { get; set; } = null!;
        public string Soppsswd10 { get; set; } = null!;
        public byte[] Ivcdstck { get; set; } = null!;
        public int Numoftrx { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public string Usrdrpr5 { get; set; } = null!;
        public string Usrdrpr6 { get; set; } = null!;
        public string Usrdrpr7 { get; set; } = null!;
        public string Usrdrpr8 { get; set; } = null!;
        public string Usrdrpr9 { get; set; } = null!;
        public string Usrdrp10 { get; set; } = null!;
        public string Usrdrp11 { get; set; } = null!;
        public string Usrdrp12 { get; set; } = null!;
        public string Usrdfpr13 { get; set; } = null!;
        public string Usrdfpr14 { get; set; } = null!;
        public string Usrdfpr15 { get; set; } = null!;
        public string Usrdfpr16 { get; set; } = null!;
        public string Usrdfpr17 { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public short Reqship { get; set; }
        public short Reqdays { get; set; }
        public short Sitepref { get; set; }
        public string Prefsite { get; set; } = null!;
        public short Reqdatepo { get; set; }
        public short RequiredDays { get; set; }
        public short Umdefault { get; set; }
        public byte Combonpo { get; set; }
        public byte Txbasecs { get; set; }
        public byte Useorguc { get; set; }
        public byte PricesNotRequiredInPr { get; set; }
        public string PasswordUpper { get; set; } = null!;
        public byte ConvertFunctionalPrice { get; set; }
        public short Indvpickticketsort { get; set; }
        public short Printavailablebins { get; set; }
        public string Fodocid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
