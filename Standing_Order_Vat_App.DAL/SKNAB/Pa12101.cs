using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa12101
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public int PalineItemSeq { get; set; }
        public decimal Pavartotfeeamt { get; set; }
        public short Pasequencenumber { get; set; }
        public DateTime Pabegindate { get; set; }
        public DateTime PaenDate { get; set; }
        public decimal Patotprjfeeamt { get; set; }
        public decimal Patotretnfeeamt { get; set; }
        public decimal Patotretntnamt { get; set; }
        public decimal Patotsrvcfeeamt { get; set; }
        public byte PacloseCb { get; set; }
        public decimal Pavarprjfeeamt { get; set; }
        public decimal Pavarretfeeamt { get; set; }
        public decimal Pavaretnfeeamt { get; set; }
        public decimal Pavarservfeeamt { get; set; }
        public decimal PapostedProjectFee { get; set; }
        public decimal PapostedRetainerFee { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal PapostedServiceFee { get; set; }
        public int DexRowId { get; set; }
    }
}
