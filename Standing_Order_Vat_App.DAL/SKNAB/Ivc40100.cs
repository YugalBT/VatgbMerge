using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ivc40100
    {
        public short Setupkey { get; set; }
        public byte Dpyitmcs { get; set; }
        public byte Acdstrbn { get; set; }
        public byte Trkvdtrx { get; set; }
        public byte Trxdtl { get; set; }
        public string Locncode { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public short Invcfrmt { get; set; }
        public short Retnfrmt { get; set; }
        public short Pkslpfmt { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Useadvtx { get; set; }
        public string Nonivsch { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public short Nonivtxb { get; set; }
        public short Frgttxbl { get; set; }
        public short Misctxbl { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public short Useacfrm { get; set; }
        public byte Rtnusivc { get; set; }
        public byte Pkslpivc { get; set; }
        public string Commntid { get; set; } = null!;
        public byte Ivcallow1 { get; set; }
        public byte Ivcallow2 { get; set; }
        public byte Ivcallow3 { get; set; }
        public byte Ivcallow4 { get; set; }
        public byte Ivcallow5 { get; set; }
        public byte Ivcallow6 { get; set; }
        public byte Ivcallow7 { get; set; }
        public byte Ivcallow8 { get; set; }
        public byte Ivcallow9 { get; set; }
        public byte Ivcallow10 { get; set; }
        public byte Ivcallow11 { get; set; }
        public string Ivcpsswd1 { get; set; } = null!;
        public string Ivcpsswd2 { get; set; } = null!;
        public string Ivcpsswd3 { get; set; } = null!;
        public string Ivcpsswd4 { get; set; } = null!;
        public string Ivcpsswd5 { get; set; } = null!;
        public string Ivcpsswd6 { get; set; } = null!;
        public string Ivcpsswd7 { get; set; } = null!;
        public string Ivcpsswd8 { get; set; } = null!;
        public string Ivcpsswd9 { get; set; } = null!;
        public string Ivcpsswd10 { get; set; } = null!;
        public string Ivcpsswd11 { get; set; } = null!;
        public short Ivcseqnc1 { get; set; }
        public short Ivcseqnc2 { get; set; }
        public short Ivcseqnc3 { get; set; }
        public short Ivcseqnc4 { get; set; }
        public short Ivcseqnc5 { get; set; }
        public short Ivcseqnc6 { get; set; }
        public short Ivcseqnc7 { get; set; }
        public short Ivcseqnc8 { get; set; }
        public short Ivcseqnc9 { get; set; }
        public short Ivcseqnc10 { get; set; }
        public short Ivcseqnc11 { get; set; }
        public byte[] Ivcdstck { get; set; } = null!;
        public int Numoftrx { get; set; }
        public int DexRowId { get; set; }
    }
}
