using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa45000
    {
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public byte Askechtm { get; set; }
        public short Iffilxst { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Prnttype { get; set; }
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Reportid { get; set; }
        public string Fareptname { get; set; } = null!;
        public short Sortby { get; set; }
        public string SortByValue { get; set; } = null!;
        public int Bookindx { get; set; }
        public string Bookid { get; set; } = null!;
        public short Currfiscalyr { get; set; }
        public DateTime BeginCurrentFiscalYr { get; set; }
        public DateTime EndCurrentFiscalYear { get; set; }
        public int SecondBookIndex { get; set; }
        public string SecondBookId { get; set; } = null!;
        public short CurrentFiscalYear2 { get; set; }
        public DateTime SecondBeginCurrentFy { get; set; }
        public DateTime SecondEndCurrentFy { get; set; }
        public byte Active { get; set; }
        public byte Retired { get; set; }
        public byte Partialopen { get; set; }
        public byte MulticurrencyInformation { get; set; }
        public byte InDetail { get; set; }
        public byte OnlyNotInterfaced { get; set; }
        public string StartMasterAssetId { get; set; } = null!;
        public string EndMasterAssetId { get; set; } = null!;
        public string StartAssetId { get; set; } = null!;
        public string EndAssetId { get; set; } = null!;
        public short StartAssetIdSuffix { get; set; }
        public short EndAssetIdSuffix { get; set; }
        public string StartAssetDescription { get; set; } = null!;
        public string EndAssetDescription { get; set; } = null!;
        public string StartStructureId { get; set; } = null!;
        public string EndStructureId { get; set; } = null!;
        public string Sttclsid { get; set; } = null!;
        public string Endclsid { get; set; } = null!;
        public string Sttlocid { get; set; } = null!;
        public string Endlocid { get; set; } = null!;
        public decimal StartYtdDepreciation { get; set; }
        public decimal EndYtdDepreciation { get; set; }
        public decimal StartLtdDepreciation { get; set; }
        public decimal EndLtdDepreciation { get; set; }
        public decimal StartNetBookValue { get; set; }
        public decimal EndNetBookValue { get; set; }
        public string Ssrcedoc { get; set; } = null!;
        public string Endsrcdc { get; set; } = null!;
        public int StartGlAccountIndex { get; set; }
        public int EndGlAccountIndex { get; set; }
        public short StartFaYear { get; set; }
        public short EndFaYear { get; set; }
        public short StartFaPeriod { get; set; }
        public short EndFaPeriod { get; set; }
        public short StartPropertyType { get; set; }
        public short EndPropertyType { get; set; }
        public short StartAssetType { get; set; }
        public short EndAssetType { get; set; }
        public int StartAssetQuantity { get; set; }
        public int EndAssetQuantity { get; set; }
        public short StartOriginalLifeYear { get; set; }
        public short EndOriginalLifeYears { get; set; }
        public short StartOriginalLifeDays { get; set; }
        public short EndOriginalLifeDays { get; set; }
        public short StartRemainingLifeYea { get; set; }
        public short EndRemainingLifeYears { get; set; }
        public short StartRemainingLifeDay { get; set; }
        public short EndRemainingLifeDays { get; set; }
        public short StartDeprMethod { get; set; }
        public short EndDepreciationMethod { get; set; }
        public short StartAveragingConventi { get; set; }
        public short EndAveragingConvention { get; set; }
        public short StartAmortizationCode { get; set; }
        public short EndAmortizationCode { get; set; }
        public short StartRetirementType { get; set; }
        public short EndRetirementType { get; set; }
        public short StartTrxAcctType { get; set; }
        public short EndTrxAcctType { get; set; }
        public decimal StartCostBasis { get; set; }
        public decimal EndCostBasis { get; set; }
        public short StartFiscalYearAdded { get; set; }
        public short EndFiscalYearAdded { get; set; }
        public DateTime StartPlaceInService { get; set; }
        public DateTime EndPlaceInService { get; set; }
        public string StartPisToken { get; set; } = null!;
        public string EndPisToken { get; set; } = null!;
        public DateTime StartAcquisitionDate { get; set; }
        public DateTime EndAcquisitionDate { get; set; }
        public string StartAcqToken { get; set; } = null!;
        public string EndAcqToken { get; set; } = null!;
        public DateTime StartDateAdded { get; set; }
        public DateTime EndDateAdded { get; set; }
        public string StartDateAddedToken { get; set; } = null!;
        public string EndDateAddedToken { get; set; } = null!;
        public DateTime StartFullyDeprDate { get; set; }
        public DateTime EndFullyDeprDate { get; set; }
        public string StartFullyDtdToken { get; set; } = null!;
        public string EndFullyDtdToken { get; set; } = null!;
        public DateTime StartRetirementDate { get; set; }
        public DateTime EndRetirementDate { get; set; }
        public string StartRetDateToken { get; set; } = null!;
        public string EndRetDateToken { get; set; } = null!;
        public DateTime StartTransferDate { get; set; }
        public DateTime EndTransferDate { get; set; }
        public string StartTransferDateToke { get; set; } = null!;
        public string EndTransferDateToken { get; set; } = null!;
        public DateTime StartSwitchoverDate { get; set; }
        public DateTime EndSwitchoverDate { get; set; }
        public string StartSwitchDateToken { get; set; } = null!;
        public string EndSwitchDateToken { get; set; } = null!;
        public DateTime StartGlIntfTrxDate { get; set; }
        public DateTime EndGlIntfTrxDate { get; set; }
        public string StartGlIntfDateToken { get; set; } = null!;
        public string EndGlIntfDateToken { get; set; } = null!;
        public string Stbchnum { get; set; } = null!;
        public string Endbnmbr { get; set; } = null!;
        public short Fiscalyear { get; set; }
        public DateTime Projfrom { get; set; }
        public DateTime Projto { get; set; }
        public int DexRowId { get; set; }
    }
}
