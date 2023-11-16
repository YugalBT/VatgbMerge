using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa70101
    {
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Reportid { get; set; }
        public string Rptgrnms { get; set; } = null!;
        public byte Askechtm { get; set; }
        public byte Prtoscrn { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prntofil { get; set; }
        public short Expttype { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Iffilxst { get; set; }
        public short Prnttype { get; set; }
        public short Sortby { get; set; }
        public short Rangeby { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public short Patu { get; set; }
        public short PareportInclude { get; set; }
        public byte ParangeByArray1 { get; set; }
        public byte ParangeByArray2 { get; set; }
        public byte ParangeByArray3 { get; set; }
        public byte ParangeByArray4 { get; set; }
        public byte ParangeByArray5 { get; set; }
        public byte ParangeByArray6 { get; set; }
        public byte ParangeByArray7 { get; set; }
        public byte ParangeByArray8 { get; set; }
        public byte ParangeByArray9 { get; set; }
        public byte ParangeByArray10 { get; set; }
        public byte PaexcludeArray1 { get; set; }
        public byte PaexcludeArray2 { get; set; }
        public byte PaexcludeArray3 { get; set; }
        public byte PaexcludeArray4 { get; set; }
        public byte PaexcludeArray5 { get; set; }
        public byte PaexcludeArray6 { get; set; }
        public byte PaexcludeArray7 { get; set; }
        public byte PaexcludeArray8 { get; set; }
        public byte PaexcludeArray9 { get; set; }
        public byte PaexcludeArray10 { get; set; }
        public decimal PaNetWriteDownInExc { get; set; }
        public byte Detldrpt { get; set; }
        public short Mthslctd { get; set; }
        public short Sumdttkn { get; set; }
        public DateTime Smrydate { get; set; }
        public short PacashBudgetSalesLevel { get; set; }
        public short PacashBudgetPctgLevels1 { get; set; }
        public short PacashBudgetPctgLevels2 { get; set; }
        public short PacashBudgetPctgLevels3 { get; set; }
        public decimal PacashBudgetStartingCash { get; set; }
        public decimal PacashBudgetCashNeedsLev { get; set; }
        public byte Prpstjcb { get; set; }
        public byte Prtdbrcd { get; set; }
        public byte Prsbdrcb { get; set; }
        public short Strtyear { get; set; }
        public short Endyear { get; set; }
        public string Stbchnum { get; set; } = null!;
        public string Endbnmbr { get; set; } = null!;
        public int Stdocn { get; set; }
        public int Endocn { get; set; }
        public string Sttprjclid { get; set; } = null!;
        public string Endprjclid { get; set; } = null!;
        public string Pastprojn { get; set; } = null!;
        public string Paenprojn { get; set; } = null!;
        public string Sttprojid { get; set; } = null!;
        public string Endprojid { get; set; } = null!;
        public string StartProjectMgrId { get; set; } = null!;
        public string EndProjectMgrId { get; set; } = null!;
        public string StartBusinessMgrId { get; set; } = null!;
        public string EndBusinessMgrId { get; set; } = null!;
        public string Strtdept { get; set; } = null!;
        public string Enddept { get; set; } = null!;
        public string Sttcntrclid { get; set; } = null!;
        public string Endcntrclid { get; set; } = null!;
        public string StartContractNumber { get; set; } = null!;
        public string EndContractNumber { get; set; } = null!;
        public string Sttcontrid { get; set; } = null!;
        public string Endcontrid { get; set; } = null!;
        public string Stsprsid { get; set; } = null!;
        public string Enspsnid { get; set; } = null!;
        public DateTime Stdatein { get; set; }
        public DateTime Endatein { get; set; }
        public int Strefdoc { get; set; }
        public int Enrefdoc { get; set; }
        public short Stdistt { get; set; }
        public short Endistt { get; set; }
        public int Staccndx { get; set; }
        public int Edaccndx { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public string Sttudef1 { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public DateTime Sttpstdt { get; set; }
        public DateTime Endpstdt { get; set; }
        public string Strxsrc { get; set; } = null!;
        public string Entrxsrc { get; set; } = null!;
        public string Stcustid { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Stcustnm { get; set; } = null!;
        public string Encstnam { get; set; } = null!;
        public string PastartIdArray1 { get; set; } = null!;
        public string PastartIdArray2 { get; set; } = null!;
        public string PastartIdArray3 { get; set; } = null!;
        public string PastartIdArray4 { get; set; } = null!;
        public string PastartIdArray5 { get; set; } = null!;
        public string PastartIdArray6 { get; set; } = null!;
        public string PastartIdArray7 { get; set; } = null!;
        public string PastartIdArray8 { get; set; } = null!;
        public string PastartIdArray9 { get; set; } = null!;
        public string PastartIdArray10 { get; set; } = null!;
        public string PaendIdArray1 { get; set; } = null!;
        public string PaendIdArray2 { get; set; } = null!;
        public string PaendIdArray3 { get; set; } = null!;
        public string PaendIdArray4 { get; set; } = null!;
        public string PaendIdArray5 { get; set; } = null!;
        public string PaendIdArray6 { get; set; } = null!;
        public string PaendIdArray7 { get; set; } = null!;
        public string PaendIdArray8 { get; set; } = null!;
        public string PaendIdArray9 { get; set; } = null!;
        public string PaendIdArray10 { get; set; } = null!;
        public string PastartNameArray1 { get; set; } = null!;
        public string PastartNameArray2 { get; set; } = null!;
        public string PastartNameArray3 { get; set; } = null!;
        public string PastartNameArray4 { get; set; } = null!;
        public string PastartNameArray5 { get; set; } = null!;
        public string PastartNameArray6 { get; set; } = null!;
        public string PastartNameArray7 { get; set; } = null!;
        public string PastartNameArray8 { get; set; } = null!;
        public string PastartNameArray9 { get; set; } = null!;
        public string PastartNameArray10 { get; set; } = null!;
        public string PaendNameArray1 { get; set; } = null!;
        public string PaendNameArray2 { get; set; } = null!;
        public string PaendNameArray3 { get; set; } = null!;
        public string PaendNameArray4 { get; set; } = null!;
        public string PaendNameArray5 { get; set; } = null!;
        public string PaendNameArray6 { get; set; } = null!;
        public string PaendNameArray7 { get; set; } = null!;
        public string PaendNameArray8 { get; set; } = null!;
        public string PaendNameArray9 { get; set; } = null!;
        public string PaendNameArray10 { get; set; } = null!;
        public short Pastdoct { get; set; }
        public short Paendoct { get; set; }
        public int PastartPoNumber { get; set; }
        public int PaendPoNumber { get; set; }
        public short PastartTrxType { get; set; }
        public short PaendTrxType { get; set; }
        public short Prtcurin { get; set; }
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public byte Includeholdpo { get; set; }
        public byte Includeholdpoonly { get; set; }
        public byte IncludeNew { get; set; }
        public byte IncludeReleased { get; set; }
        public byte IncludeChangeOrder { get; set; }
        public byte IncludeReceived { get; set; }
        public byte IncludeClosed { get; set; }
        public byte IncludeCanceled { get; set; }
        public byte Incrcpts { get; set; }
        public string Endvndid { get; set; } = null!;
        public string Endvndnm { get; set; } = null!;
        public short Endposta { get; set; }
        public string EndPoprcptNum { get; set; } = null!;
        public byte Dissrlot { get; set; }
        public string Enitmnbr { get; set; } = null!;
        public DateTime EndPromisedDate { get; set; }
        public DateTime EndRequiredDate { get; set; }
        public string Endlocid { get; set; } = null!;
        public DateTime Enrctdt { get; set; }
        public string Endbuyerid { get; set; } = null!;
        public short Endlineorigin { get; set; }
        public DateTime Endreleasebydate { get; set; }
        public string Paendcostid { get; set; } = null!;
        public string Enaucncd { get; set; } = null!;
        public byte DaysOverdue { get; set; }
        public DateTime Dateoverdue { get; set; }
        public short Comptype { get; set; }
        public short PopDateSelection1 { get; set; }
        public byte Inclfunc { get; set; }
        public byte Incmcinf { get; set; }
        public string Stvndrid { get; set; } = null!;
        public string Stvndnam { get; set; } = null!;
        public short Strposta { get; set; }
        public string Strponum { get; set; } = null!;
        public string StartPoprcptNum { get; set; } = null!;
        public string Endponum { get; set; } = null!;
        public string Sttitnum { get; set; } = null!;
        public DateTime StartPromisedDate { get; set; }
        public DateTime StartRequiredDate { get; set; }
        public string Sttlocid { get; set; } = null!;
        public DateTime Strctdt { get; set; }
        public string Startbuyerid { get; set; } = null!;
        public short Startlineorigin { get; set; }
        public DateTime Startreleasebydate { get; set; }
        public string Pasttcostid { get; set; } = null!;
        public string Sttacncd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
