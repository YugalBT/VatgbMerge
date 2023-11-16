using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc020105
    {
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public int Seqnumbr { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Rvludate { get; set; }
        public DateTime RevalPostDate { get; set; }
        public string Ratetpid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public decimal Xchgrate { get; set; }
        public string Audittrail { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Gainloss { get; set; }
        public decimal Glcurtrx { get; set; }
        public decimal Gldscavl { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal Ordavamt { get; set; }
        public decimal Curtrxar { get; set; }
        public decimal Dscavaar { get; set; }
        public decimal UnsettledCurrentGainLoss { get; set; }
        public decimal UnsettledAvailGainLoss { get; set; }
        public decimal TotalGainOrLossOnCu { get; set; }
        public decimal TotalGainOrLossOnDi { get; set; }
        public int Curtrxai { get; set; }
        public int Dscavaai { get; set; }
        public int Rvlueidx { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
