using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa01401
    {
        public int Assetindex { get; set; }
        public int Purchlineseq { get; set; }
        public string Purchdesc { get; set; } = null!;
        public decimal AcquisitionCost { get; set; }
        public decimal OrigAcquisitionCost { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Orctrnum { get; set; } = null!;
        public int FaApPostIndex { get; set; }
        public string Pordnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Exgtblid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
