using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01801
    {
        public short Maskid { get; set; }
        public string Palongform { get; set; } = null!;
        public string Sgmtnams1 { get; set; } = null!;
        public string Sgmtnams2 { get; set; } = null!;
        public string Sgmtnams3 { get; set; } = null!;
        public string Sgmtnams4 { get; set; } = null!;
        public string Sgmtnams5 { get; set; } = null!;
        public string Sgmtnams6 { get; set; } = null!;
        public short Lofsgnts1 { get; set; }
        public short Lofsgnts2 { get; set; }
        public short Lofsgnts3 { get; set; }
        public short Lofsgnts4 { get; set; }
        public short Lofsgnts5 { get; set; }
        public short Nofsgmnt { get; set; }
        public int DexRowId { get; set; }
    }
}
