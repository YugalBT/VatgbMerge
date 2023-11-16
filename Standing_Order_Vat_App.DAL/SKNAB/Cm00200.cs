using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cm00200
    {
        public string MerchantId { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Efthash { get; set; } = null!;
        public string EfthashCode { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Isocurrc { get; set; } = null!;
        public string FilePath { get; set; } = null!;
        public string EftdownLoadFilePath { get; set; } = null!;
        public string EftprocessedFilePath { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
