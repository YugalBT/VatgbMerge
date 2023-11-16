using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00620
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public decimal SvcContractLineSeq { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
