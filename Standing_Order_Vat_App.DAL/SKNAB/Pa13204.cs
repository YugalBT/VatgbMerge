using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa13204
    {
        public string Padocnumber20 { get; set; } = null!;
        public short Pabilltrxt { get; set; }
        public short Disttype { get; set; }
        public int Seqnumbr { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public int Dstindx { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Crdtamnt { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
