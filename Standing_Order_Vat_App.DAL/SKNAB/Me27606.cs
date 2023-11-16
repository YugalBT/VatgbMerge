using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me27606
    {
        public string Vendorid { get; set; } = null!;
        public DateTime MeDatePrenoteDone { get; set; }
        public DateTime MeTerminationDate { get; set; }
        public string MeReceivingDfi { get; set; } = null!;
        public string MeReceivingAccount { get; set; } = null!;
        public short MeAccountType { get; set; }
        public byte MePrenoteRejected { get; set; }
        public string Curncyid { get; set; } = null!;
        public short EfttransferMethod { get; set; }
        public string MesenderId { get; set; } = null!;
        public string MereceiverId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
