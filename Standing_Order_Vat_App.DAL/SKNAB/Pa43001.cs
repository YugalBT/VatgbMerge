using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa43001
    {
        public short Pasfid { get; set; }
        public string Parecordid { get; set; } = null!;
        public string Pacosttrxid { get; set; } = null!;
        public short Paaccttype { get; set; }
        public int Paactindx { get; set; }
        public int DexRowId { get; set; }
    }
}
