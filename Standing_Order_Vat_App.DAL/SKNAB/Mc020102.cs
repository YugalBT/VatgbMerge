using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc020102
    {
        public short Dcstatus { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal Orslsamt { get; set; }
        public decimal Orcstamt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Ormiscamt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Orcasamt { get; set; }
        public decimal Orchkamt { get; set; }
        public decimal Orccdamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordavamt { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Ordisrtd { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Ororgtrx { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal Orbktsls { get; set; }
        public decimal Orbktfrt { get; set; }
        public decimal Orbktmsc { get; set; }
        public decimal Unganlos { get; set; }
        public byte[] Rmmcerrs { get; set; } = null!;
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal OrigBackoutTradeDisc { get; set; }
        public int DexRowId { get; set; }
    }
}
