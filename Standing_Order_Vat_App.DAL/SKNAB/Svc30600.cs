using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc30600
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public short ContractTransferStatus { get; set; }
        public DateTime ContractTransferDate { get; set; }
        public string Taxschid { get; set; } = null!;
        public short PriorityLevel { get; set; }
        public string Adrscode { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Timezone { get; set; } = null!;
        public decimal Contprc { get; set; }
        public short Rencnttyp { get; set; }
        public string Renprcschd { get; set; } = null!;
        public decimal Pctcryfwd { get; set; }
        public DateTime Frzend { get; set; }
        public DateTime Frxstrt { get; set; }
        public decimal Mxincpct { get; set; }
        public decimal Blktim { get; set; }
        public decimal Valtim { get; set; }
        public short Dscpctam { get; set; }
        public decimal Comdlram { get; set; }
        public string Country { get; set; } = null!;
        public string Prcstat { get; set; } = null!;
        public string Pordnmbr { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal Partpct { get; set; }
        public decimal Labpct { get; set; }
        public decimal Miscpct { get; set; }
        public decimal Pmmscpct { get; set; }
        public decimal Pmprtpct { get; set; }
        public decimal Pmlabpct { get; set; }
        public string Vendorid { get; set; } = null!;
        public decimal Retnagam { get; set; }
        public decimal Rtnbilld { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Commcode { get; set; } = null!;
        public short Comprcnt { get; set; }
        public DateTime Bilstrt { get; set; }
        public DateTime Bilend { get; set; }
        public short Billngth { get; set; }
        public short Bilprd { get; set; }
        public decimal Total { get; set; }
        public DateTime Frstbldte { get; set; }
        public decimal LastAmountBilled { get; set; }
        public DateTime Lstbldte { get; set; }
        public short Nbrcal { get; set; }
        public short Actcal { get; set; }
        public decimal Totvalcal { get; set; }
        public string Contact { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public DateTime Nxtbldte { get; set; }
        public string Cnttype { get; set; } = null!;
        public string Pricshed { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public decimal Minbil { get; set; }
        public decimal Maxbil { get; set; }
        public decimal Maxbill { get; set; }
        public byte Autoren { get; set; }
        public string Mstcntrct { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public byte Bilfrret { get; set; }
        public decimal Totbil { get; set; }
        public byte Prepaid { get; set; }
        public short Bilondy { get; set; }
        public short Bilcyc { get; set; }
        public string Uofm { get; set; } = null!;
        public short Bilstat { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Cntcovpd1 { get; set; }
        public DateTime Cntcovpd2 { get; set; }
        public DateTime Cntcovpd3 { get; set; }
        public DateTime Cntcovpd4 { get; set; }
        public DateTime Cntcovpd5 { get; set; }
        public DateTime Cntcovpd6 { get; set; }
        public DateTime Cntcovpd7 { get; set; }
        public DateTime ContractCoveragePeriod1 { get; set; }
        public DateTime ContractCoveragePeriod2 { get; set; }
        public DateTime ContractCoveragePeriod3 { get; set; }
        public DateTime ContractCoveragePeriod4 { get; set; }
        public DateTime ContractCoveragePeriod5 { get; set; }
        public DateTime ContractCoveragePeriod6 { get; set; }
        public DateTime ContractCoveragePeriod7 { get; set; }
        public byte Usecvpd1 { get; set; }
        public byte Usecvpd2 { get; set; }
        public byte Usecvpd3 { get; set; }
        public byte Usecvpd4 { get; set; }
        public byte Usecvpd5 { get; set; }
        public byte Usecvpd6 { get; set; }
        public byte Usecvpd7 { get; set; }
        public short ContractLength { get; set; }
        public short ContractPeriod { get; set; }
        public decimal InvoicedAmount { get; set; }
        public byte LiabiltiyReduction { get; set; }
        public decimal AmountToInvoice { get; set; }
        public decimal LiabilityAmount { get; set; }
        public decimal TotalLiabilityAmount { get; set; }
        public int Numofinv { get; set; }
        public short QuoteStatus { get; set; }
        public DateTime Quoexpda { get; set; }
        public byte CreditHold { get; set; }
        public string Taxexmt1 { get; set; } = null!;
        public string Taxexmt2 { get; set; } = null!;
        public byte NewPoRequired { get; set; }
        public string ContractRenewalContact { get; set; } = null!;
        public string SourceContractNumber { get; set; } = null!;
        public short SourceContractType { get; set; }
        public string ContractResponseTime { get; set; } = null!;
        public short LiabilityMonths { get; set; }
        public DateTime NextLiabilityDate { get; set; }
        public DateTime LastLiabilityDate { get; set; }
        public decimal TotalLiabilityBilled { get; set; }
        public decimal TotalUnit { get; set; }
        public string CreatedUserId { get; set; } = null!;
        public string SourceUserId { get; set; } = null!;
        public DateTime SvcContractSigned { get; set; }
        public short SvcLiabilityType { get; set; }
        public string Rettype { get; set; } = null!;
        public string LocationSegment { get; set; } = null!;
        public string BillToCustomer { get; set; } = null!;
        public byte SvcInvoiceDetail { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string SvcBillToAddressCode { get; set; } = null!;
        public decimal Dscdlram { get; set; }
        public byte SvcPaidContract { get; set; }
        public decimal SvcDiscountRecognized { get; set; }
        public decimal SvcDiscountRemaining { get; set; }
        public decimal SvcDiscountNext { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public short Decplacs { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public short Viewmode { get; set; }
        public short Ismctrx { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Origvaltim { get; set; }
        public decimal Orcomamt { get; set; }
        public decimal Origretnagam { get; set; }
        public decimal Origrtnbilld { get; set; }
        public decimal Origtotal { get; set; }
        public decimal OriglastamountBilled { get; set; }
        public decimal Origtotvalcal { get; set; }
        public decimal Origminbil { get; set; }
        public decimal Origmaxbil { get; set; }
        public decimal OriginatingMaxBillable { get; set; }
        public decimal Origtotbil { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public decimal OrigAmountToInvoice { get; set; }
        public decimal OrigLiabilityAmount { get; set; }
        public decimal OrigTotLiabilityAmount { get; set; }
        public decimal OrigTotLiabBilled { get; set; }
        public decimal OriginatingTotalUnit { get; set; }
        public decimal Orddlrat { get; set; }
        public decimal OrigDiscountReceived { get; set; }
        public decimal OrigDiscountRemaining { get; set; }
        public decimal OrigDiscountNext { get; set; }
        public byte SmoothInvoiceCalc { get; set; }
        public byte SmoothRevenueCalc { get; set; }
        public byte SvcUseSameNumber { get; set; }
        public string SvcFoId { get; set; } = null!;
        public decimal SvcInvoicedCost { get; set; }
        public decimal OrigSvcInvoicedCost { get; set; }
        public short SvcContractVersion { get; set; }
        public byte SvcEvergreenContract { get; set; }
        public short SvcEvergreenRenewLimit { get; set; }
        public short SvcEvergreenRenewals { get; set; }
        public string SvcNewContractNumber { get; set; } = null!;
        public string SvcNewPoNumber { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
