using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl20000
    {
        public short Openyear { get; set; }
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public string Trxsorce { get; set; } = null!;
        public int Actindx { get; set; }
        public byte Polldtrx { get; set; }
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Uswhpstd { get; set; } = null!;
        public string Orgntsrc { get; set; } = null!;
        public short Orgnatyp { get; set; }
        public short Qkofset { get; set; }
        public short Series { get; set; }
        public short Ortrxtyp { get; set; }
        public string Orctrnum { get; set; } = null!;
        public string Ormstrid { get; set; } = null!;
        public string Ormstrnm { get; set; } = null!;
        public string Ordocnum { get; set; } = null!;
        public DateTime Orpstddt { get; set; }
        public string Ortrxsrc { get; set; } = null!;
        public short OrigDtaseries { get; set; }
        public int OrigSeqNum { get; set; }
        public int Seqnumbr { get; set; }
        public short DtaGlStatus { get; set; }
        public decimal DtaIndex { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Rtclcmtd { get; set; }
        public decimal Noteindx { get; set; }
        public byte Ictrx { get; set; }
        public string Orcomid { get; set; } = null!;
        public int Originje { get; set; }
        public short Periodid { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public decimal Orcrdamt { get; set; }
        public decimal Ordbtamt { get; set; }
        public DateTime Docdate { get; set; }
        public int Pstgnmbr { get; set; }
        public int Ppsgnmbr { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public string CorrespondingUnit { get; set; } = null!;
        public byte Voided { get; set; }
        public int BackOutJe { get; set; }
        public short BackOutJeYear { get; set; }
        public int CorrectingJe { get; set; }
        public short CorrectingJeYear { get; set; }
        public int OriginalJe { get; set; }
        public decimal OriginalJeSeqNum { get; set; }
        public short OriginalJeYear { get; set; }
        public int DexRowId { get; set; }
    }
}
