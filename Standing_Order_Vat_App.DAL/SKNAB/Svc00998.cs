using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00998
    {
        public decimal Sequence1 { get; set; }
        public short Srvrectype { get; set; }
        public byte Mulequip { get; set; }
        public byte Mulcodes { get; set; }
        public byte Multech { get; set; }
        public string Timezone { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Srvstat { get; set; } = null!;
        public string BackorderStatus { get; set; } = null!;
        public string IntransitStatus { get; set; } = null!;
        public string DispatchStatus { get; set; } = null!;
        public string ArrivalStatus { get; set; } = null!;
        public string CompleteStatus { get; set; } = null!;
        public string Postat { get; set; } = null!;
        public byte SinglePo { get; set; }
        public string Srlstat { get; set; } = null!;
        public string Retstatus { get; set; } = null!;
        public byte Cksvcarea { get; set; }
        public byte Ckskill { get; set; }
        public short Consts { get; set; }
        public string Pricshed { get; set; } = null!;
        public string Cnttype { get; set; } = null!;
        public string Mapprloc { get; set; } = null!;
        public string Usrdfpr1 { get; set; } = null!;
        public string Usrdrpr2 { get; set; } = null!;
        public string Usrdrpr3 { get; set; } = null!;
        public string Usrdrpr4 { get; set; } = null!;
        public string Usrdrpr5 { get; set; } = null!;
        public short Numdaysod { get; set; }
        public short Numdayspm { get; set; }
        public short Numdayscb { get; set; }
        public byte Chghist { get; set; }
        public byte Autocust { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Retcstnr { get; set; } = null!;
        public byte Pageon { get; set; }
        public string Pageprofile { get; set; } = null!;
        public string Prclevel { get; set; } = null!;
        public byte UseSop { get; set; }
        public string PasswordArray1 { get; set; } = null!;
        public string PasswordArray2 { get; set; } = null!;
        public string PasswordArray3 { get; set; } = null!;
        public string PasswordArray4 { get; set; } = null!;
        public string PasswordArray5 { get; set; } = null!;
        public string PasswordArray6 { get; set; } = null!;
        public string PasswordArray7 { get; set; } = null!;
        public byte CheckCustomer { get; set; }
        public byte CheckCustomerAddress { get; set; }
        public byte CheckSerial { get; set; }
        public byte EmailTech { get; set; }
        public short UsePop { get; set; }
        public byte PrintToWeb { get; set; }
        public byte CheckCallBack { get; set; }
        public short RetainagePercent { get; set; }
        public string Rettype { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public short SvcPoValidation { get; set; }
        public string LocationCodeVendor { get; set; } = null!;
        public short Worectype { get; set; }
        public string WoOfficeId { get; set; } = null!;
        public string WoTimeZone { get; set; } = null!;
        public string Woentsta { get; set; } = null!;
        public string Wobostat { get; set; } = null!;
        public string Wocompstat { get; set; } = null!;
        public string Wowipstat { get; set; } = null!;
        public string Wotype { get; set; } = null!;
        public string Wolocat { get; set; } = null!;
        public string PartsAvailableStatus { get; set; } = null!;
        public short SvcAddressOption { get; set; }
        public byte SvcDisableXfrGrouping { get; set; }
        public string ReadyToInvoiceStatus { get; set; } = null!;
        public string InvoicedStatus { get; set; } = null!;
        public short SvcAutoCreateLabor { get; set; }
        public string Usrdrpr6 { get; set; } = null!;
        public string Usrdrpr7 { get; set; } = null!;
        public string Usrdrpr8 { get; set; } = null!;
        public string Usrdrpr9 { get; set; } = null!;
        public string Usrdrp10 { get; set; } = null!;
        public string SvcUserDefinePrompt1 { get; set; } = null!;
        public string SvcUserDefinePrompt2 { get; set; } = null!;
        public string SvcUserDefinePrompt3 { get; set; } = null!;
        public string SvcUserDefinePrompt4 { get; set; } = null!;
        public string SvcUserDefinePrompt5 { get; set; } = null!;
        public string SvcUserDefinePrompt6 { get; set; } = null!;
        public string SvcUserDefinePrompt7 { get; set; } = null!;
        public string SvcUserDefinePrompt8 { get; set; } = null!;
        public string SvcUserDefinePrompt9 { get; set; } = null!;
        public string SvcUserDefinePrompt10 { get; set; } = null!;
        public string SvcUserDefinePrompt11 { get; set; } = null!;
        public string SvcUserDefinePrompt12 { get; set; } = null!;
        public string SvcUserDefinePrompt13 { get; set; } = null!;
        public string SvcUserDefinePrompt14 { get; set; } = null!;
        public string SvcUserDefinePrompt15 { get; set; } = null!;
        public short SvcCheckScLabor { get; set; }
        public short SvcCheckWoLabor { get; set; }
        public byte SvcCheckCallBack { get; set; }
        public string SvcServiceType { get; set; } = null!;
        public string SvcDirectory { get; set; } = null!;
        public string SvcReturnPriceLevel { get; set; } = null!;
        public short SvcTransferOption { get; set; }
        public string SvcServiceBatchId { get; set; } = null!;
        public string SvcServiceDocumentId { get; set; } = null!;
        public string SvcContractBatchId { get; set; } = null!;
        public string SvcContractDocumentId { get; set; } = null!;
        public byte SvcUseReturn { get; set; }
        public short SvcDupSerial { get; set; }
        public byte SvcAutoSopContract { get; set; }
        public byte SvcContractWarranty { get; set; }
        public byte SvcCreateSerial { get; set; }
        public short SvcVendorWarrantyFlag { get; set; }
        public short SvcSellerWarrantyFlag { get; set; }
        public byte SvcCreatePopSerial { get; set; }
        public byte SvcItemDelta { get; set; }
        public byte SvcAllowContract0Sop { get; set; }
        public byte SvcAllowService0Sop { get; set; }
        public string SvcCCreditBatchId { get; set; } = null!;
        public string SvcCCreditDocumentId { get; set; } = null!;
        public string SvcSCreditBatchId { get; set; } = null!;
        public string SvcSCreditDocumentId { get; set; } = null!;
        public string SvcZeroBatchId { get; set; } = null!;
        public string SvcZeroDocumentId { get; set; } = null!;
        public byte SvcAutoCreditReceipt { get; set; }
        public byte SvcAutoReplaceReceipt { get; set; }
        public string SvcRmaInvoiceBatchId { get; set; } = null!;
        public string SvcRmaCreditBatchId { get; set; } = null!;
        public string SvcRmaOrderBatchId { get; set; } = null!;
        public string CallTo { get; set; } = null!;
        public string CallFrom { get; set; } = null!;
        public short PriorityLevel { get; set; }
        public string SvcUserDefinePrompt16 { get; set; } = null!;
        public string SvcUserDefinePrompt17 { get; set; } = null!;
        public string SvcUserDefinePrompt18 { get; set; } = null!;
        public string SvcUserDefinePrompt19 { get; set; } = null!;
        public string SvcUserDefinePrompt20 { get; set; } = null!;
        public byte SvcAutoXshipReceipt { get; set; }
        public byte SvcUsePayable { get; set; }
        public byte SvcPrePaidOverride { get; set; }
        public byte SvcDistHistoryContract { get; set; }
        public byte SvcDistHistoryRma { get; set; }
        public byte SvcDistHistoryRtv { get; set; }
        public byte SvcDistHistoryService { get; set; }
        public byte SvcDistHistoryTransfer { get; set; }
        public byte SvcDistHistoryWorkOrd { get; set; }
        public byte SvcUseSameNumber { get; set; }
        public string SvcInStockCustomer { get; set; } = null!;
        public string SvcInStockStatus { get; set; } = null!;
        public byte SvcCreateNonSerialEq { get; set; }
        public byte SvcAllowRma0Sop { get; set; }
        public byte SvcUseReturnPriceLev { get; set; }
        public byte SvcSupersessionEnabled { get; set; }
        public byte Autoren { get; set; }
        public short SvcDaysToRenew { get; set; }
        public decimal Mxincpct { get; set; }
        public decimal Pctcryfwd { get; set; }
        public byte SvcRemovePriceOverrid { get; set; }
        public string Renprcschd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
