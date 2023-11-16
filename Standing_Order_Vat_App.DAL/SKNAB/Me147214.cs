using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me147214
    {
        public string Custnmbr { get; set; } = null!;
        public DateTime MeDatePrenoteDone { get; set; }
        public DateTime MeTerminationDate { get; set; }
        public string MeReceivingDfi { get; set; } = null!;
        public string MeReceivingAccount { get; set; } = null!;
        public short MeAccountType { get; set; }
        public byte MePrenoteRejected { get; set; }
        public string Curncyid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
