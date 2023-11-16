using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc35200
    {
        public string Retdocid { get; set; } = null!;
        public short ReturnRecordType { get; set; }
        public decimal Lnseqnbr { get; set; }
        public decimal SvcNextLineSeqNumber { get; set; }
        public decimal SvcPrevLineSeqNumber { get; set; }
        public string Rettype { get; set; } = null!;
        public short RmaStatus { get; set; }
        public string Retstat { get; set; } = null!;
        public byte Received { get; set; }
        public byte TravelerPrinted { get; set; }
        public byte SvcReadyToClose { get; set; }
        public string SvcRmaReasonCode { get; set; } = null!;
        public string SvcRmaReasonCodeDesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Retorig { get; set; }
        public string Retref { get; set; } = null!;
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public byte SvcRmaFromService { get; set; }
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int Cmpntseq { get; set; }
        public int SopLineItemSequence { get; set; }
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime CommitDate { get; set; }
        public DateTime CommitTime { get; set; }
        public DateTime Retudate { get; set; }
        public DateTime ReturnTime { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public DateTime Prmdate { get; set; }
        public string Refrence { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Rtrnname { get; set; } = null!;
        public string Retaddr1 { get; set; } = null!;
        public string Retaddr2 { get; set; } = null!;
        public string Retaddr3 { get; set; } = null!;
        public string Rtrncity { get; set; } = null!;
        public string SvcReturnState { get; set; } = null!;
        public string Rtrnzip { get; set; } = null!;
        public string ReturnCountry { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string BillToCustomer { get; set; } = null!;
        public string SvcBillToAddressCode { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public decimal Quantity { get; set; }
        public short Decplqty { get; set; }
        public string Uofm { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Extdcost { get; set; }
        public decimal Orextcst { get; set; }
        public decimal Unitprce { get; set; }
        public decimal Oruntprc { get; set; }
        public decimal Xtndprce { get; set; }
        public decimal Oxtndprc { get; set; }
        public byte Custown { get; set; }
        public byte Factseal { get; set; }
        public string Orddocid { get; set; } = null!;
        public int Translineseq { get; set; }
        public short Status { get; set; }
        public decimal FlatRateRepairPrice { get; set; }
        public decimal OrigFlatRepairPrice { get; set; }
        public decimal RepairPrice { get; set; }
        public decimal OriginatingRepairPrice { get; set; }
        public decimal NtePrice { get; set; }
        public decimal OriginatingNtePrice { get; set; }
        public decimal RepairCost { get; set; }
        public decimal OriginatingRepairCost { get; set; }
        public string BillOfLading { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public short CreditSopType { get; set; }
        public string CreditSopNumber { get; set; } = null!;
        public int CreditSopLineItemSeq { get; set; }
        public short ReplaceSopType { get; set; }
        public string ReplaceSopNumber { get; set; } = null!;
        public int ReplaceSopLineItemSe { get; set; }
        public string LocationCodeReplacemen { get; set; } = null!;
        public string ReplaceItemNumber { get; set; } = null!;
        public string ReplaceUOfM { get; set; } = null!;
        public string ReplacePriceLevel { get; set; } = null!;
        public decimal ReplaceQty { get; set; }
        public decimal ReplaceCost { get; set; }
        public decimal OriginatingReplaceCost { get; set; }
        public decimal ReplacePrice { get; set; }
        public decimal OriginatingReplacePric { get; set; }
        public string SopNumberInvoice { get; set; } = null!;
        public string ItemNumberInvoice { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public short Currnidx { get; set; }
        public short Decplcur { get; set; }
        public short Odecplcu { get; set; }
        public string ReturnItemNumber { get; set; } = null!;
        public string ReturnItemDescription { get; set; } = null!;
        public string ReturnLocationCode { get; set; } = null!;
        public decimal ReturnQty { get; set; }
        public string ReturnUOfM { get; set; } = null!;
        public decimal Retcost { get; set; }
        public decimal OriginatingReturnCost { get; set; }
        public decimal SvcExtendedReturnCost { get; set; }
        public decimal SvcOrigExtReturnCost { get; set; }
        public string SvcReturnPriceLevel { get; set; } = null!;
        public decimal SvcReturnPrice { get; set; }
        public decimal OriginatingReturnPrice { get; set; }
        public decimal SvcExtendedReturnPric { get; set; }
        public decimal SvcOrigExtReturnPric { get; set; }
        public string SvcFoId { get; set; } = null!;
        public short SvcScmComplete { get; set; }
        public int DexRowId { get; set; }
    }
}
