using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy03100
    {
        public short Pyblgrbx { get; set; }
        public short Rcvbgrbx { get; set; }
        public string Cardname { get; set; } = null!;
        public byte Cbpayble { get; set; }
        public byte Cbrcvble { get; set; }
        public string Ckbknum1 { get; set; } = null!;
        public string Ckbknum2 { get; set; } = null!;
        public int Actindx { get; set; }
        public string Vendorid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Lstusred { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
