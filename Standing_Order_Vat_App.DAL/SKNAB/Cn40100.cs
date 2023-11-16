using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn40100
    {
        public short Crlmtper { get; set; }
        public short SalesModule { get; set; }
        public short Keynumbr { get; set; }
        public short PreferredContactMethod { get; set; }
        public short TimeZone { get; set; }
        public byte CnUseCreditLevels { get; set; }
        public short CnOverdueView { get; set; }
        public short CnCreditControlCycle { get; set; }
        public byte SaveNoteRevisionHistory { get; set; }
        public byte WriteSelectedInvToNote { get; set; }
        public short CnUseECollect { get; set; }
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public string Usrdrpr5 { get; set; } = null!;
        public string Usrdrpr6 { get; set; } = null!;
        public string Usrdrpr7 { get; set; } = null!;
        public string Usrdrpr8 { get; set; } = null!;
        public byte CnCreateRmFcTrx { get; set; }
        public short CnEmailAttachmentFmt { get; set; }
        public short CnAgingOption { get; set; }
        public short Nmbrofdys { get; set; }
        public int DexRowId { get; set; }
    }
}
