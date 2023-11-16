using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc020103
    {
        public short Dcstatus { get; set; }
        public short Doctype { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public string Pmntnmbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Orctrxam { get; set; }
        public decimal Opuramt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Orcasamt { get; set; }
        public decimal Orchkamt { get; set; }
        public decimal Orchkttl { get; set; }
        public decimal Orccdamt { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Obkpuramt { get; set; }
        public decimal Orbktfrt { get; set; }
        public decimal Orbktmsc { get; set; }
        public decimal Unganlos { get; set; }
        public byte[] Rmmcerrs { get; set; } = null!;
        public decimal Ochgamt { get; set; }
        public decimal Ordocamt { get; set; }
        public decimal Odisamtav { get; set; }
        public decimal Orgapdisctkn { get; set; }
        public decimal Ototpay { get; set; }
        public decimal Or1099am { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal OrigBackoutTradeDisc { get; set; }
        public int DexRowId { get; set; }
    }
}
