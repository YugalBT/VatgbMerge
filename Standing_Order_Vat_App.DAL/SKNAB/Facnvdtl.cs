using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Facnvdtl
    {
        public string Assetid { get; set; } = null!;
        public short Assetidsuf { get; set; }
        public string ImportRecordType { get; set; } = null!;
        public string Bookid { get; set; } = null!;
        public int Indxlong { get; set; }
        public int Seqnumbr { get; set; }
        public short Erricon { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
