using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me147217
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public decimal Trxamnt { get; set; }
        public string Chekbkid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public DateTime Docdate { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
