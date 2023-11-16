using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl10000
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public int Jrnentry { get; set; }
        public decimal Rctrxseq { get; set; }
        public string Sourcdoc { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public DateTime Rvrsngdt { get; set; }
        public byte Rcrngtrx { get; set; }
        public short Balfrclc { get; set; }
        public short Pstgstus { get; set; }
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Uswhpstd { get; set; } = null!;
        public short Trxtype { get; set; }
        public decimal Sqncline { get; set; }
        public byte[] Glhdrmsg { get; set; } = null!;
        public byte[] Glhdrms2 { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Rvtrxsrc { get; set; } = null!;
        public short Series { get; set; }
        public DateTime Orpstddt { get; set; }
        public string Ortrxsrc { get; set; } = null!;
        public short OrigDtaseries { get; set; }
        public string DtacontrolNum { get; set; } = null!;
        public short Dtatrxtype { get; set; }
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
        public byte[] Glhdrval { get; set; } = null!;
        public short Periodid { get; set; }
        public short Openyear { get; set; }
        public short Closedyr { get; set; }
        public byte Histrx { get; set; }
        public short Revprdid { get; set; }
        public short Revyear { get; set; }
        public short Revclyr { get; set; }
        public byte Revhist { get; set; }
        public int Errstate { get; set; }
        public byte Ictrx { get; set; }
        public string Orcomid { get; set; } = null!;
        public int Originje { get; set; }
        public byte Icdists { get; set; }
        public short Prntstus { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public byte Voided { get; set; }
        public int OriginalJe { get; set; }
        public short OriginalJeYear { get; set; }
        public decimal OriginalJeSeqNum { get; set; }
        public short CorrectingTrxType { get; set; }
        public int DexRowId { get; set; }
    }
}
