using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00401
    {
        public string Docnumbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public short Dcstatus { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public byte Negqtysopinv { get; set; }
        public int DexRowId { get; set; }
    }
}
