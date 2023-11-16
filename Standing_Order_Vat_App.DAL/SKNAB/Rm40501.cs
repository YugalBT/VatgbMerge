using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm40501
    {
        public string Stmntid { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Stmtform { get; set; }
        public byte Prtcrlmt { get; set; }
        public byte Prtpytrm { get; set; }
        public byte Prntfnch { get; set; }
        public byte Prntmsgs { get; set; }
        public byte[] Stmntfor { get; set; } = null!;
        public short Rstracty { get; set; }
        public short Custsort { get; set; }
        public short Docsorts { get; set; }
        public decimal Agperamt1 { get; set; }
        public decimal Agperamt2 { get; set; }
        public decimal Agperamt3 { get; set; }
        public decimal Agperamt4 { get; set; }
        public decimal Agperamt5 { get; set; }
        public decimal Agperamt6 { get; set; }
        public decimal Agperamt7 { get; set; }
        public short Stmtrstr { get; set; }
        public string Rstrfrid { get; set; } = null!;
        public string Rstrtoid { get; set; } = null!;
        public string Rstrfnam { get; set; } = null!;
        public string Rstrtnam { get; set; } = null!;
        public string Rstrfcls { get; set; } = null!;
        public string Rstrtcls { get; set; } = null!;
        public string Rstrfrud { get; set; } = null!;
        public string Rstrtoud { get; set; } = null!;
        public string Rstfspsn { get; set; } = null!;
        public string Rsttspsn { get; set; } = null!;
        public string Rstrfter { get; set; } = null!;
        public string Rsttoter { get; set; } = null!;
        public string Rstrfzip { get; set; } = null!;
        public string Rstrtzip { get; set; } = null!;
        public short Rstfstcy { get; set; }
        public short Rsttstcy { get; set; }
        public DateTime Stmtlptd { get; set; }
        public short Prtdttkn { get; set; }
        public short Sumdttkn { get; set; }
        public short Cofdtokn { get; set; }
        public DateTime Stmtprdt { get; set; }
        public DateTime Smrydate { get; set; }
        public DateTime Cutofdat { get; set; }
        public byte Askechtm { get; set; }
        public short Expttype { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Iffilxst { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public string Locatnid { get; set; } = null!;
        public byte Indchldstmt { get; set; }
        public short EmailStatementsOptions { get; set; }
        public short EmailStatementsForm { get; set; }
        public string EmailStmtsSubjectLine { get; set; } = null!;
        public byte Rdcoldpdbyunappldcr { get; set; }
        public int DexRowId { get; set; }
    }
}
