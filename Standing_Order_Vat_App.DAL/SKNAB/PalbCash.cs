using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class PalbCash
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Bnkbrnch { get; set; } = null!;
        public string Bankname { get; set; } = null!;
        public string Bnkactnm { get; set; } = null!;
        public string LockboxId { get; set; } = null!;
        public int Errstate { get; set; }
        public int DexRowId { get; set; }
    }
}
