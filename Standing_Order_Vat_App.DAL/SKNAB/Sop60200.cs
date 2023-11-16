using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop60200
    {
        public string Instructionid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public int DexRowId { get; set; }
    }
}
