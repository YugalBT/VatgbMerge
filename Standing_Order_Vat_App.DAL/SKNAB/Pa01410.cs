using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01410
    {
        public string Paprojnumber { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string Prbtadcd { get; set; } = null!;
        public byte Pacbdefault { get; set; }
        public int DexRowId { get; set; }
    }
}
