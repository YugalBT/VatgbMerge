using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ausermst
    {
        public string Userid { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string EmpidI { get; set; } = null!;
        public short AccesslevelI { get; set; }
        public short PostIvIn { get; set; }
        public short PostPrin { get; set; }
        public short PostPurchIn { get; set; }
        public byte[] Password { get; set; } = null!;
        public string Usrclass { get; set; } = null!;
        public short Mdfrdent { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public string Lstusred { get; set; } = null!;
        public byte Prtoscrn { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Shrqflds { get; set; }
        public short Distproc { get; set; }
        public byte Hscrlarw { get; set; }
        public byte Check1I { get; set; }
        public byte Check2I { get; set; }
        public byte Check3I { get; set; }
        public byte Check4I { get; set; }
        public byte Inactive { get; set; }
        public int DexRowId { get; set; }
    }
}
