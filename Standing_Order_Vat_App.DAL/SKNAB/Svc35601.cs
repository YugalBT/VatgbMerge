using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc35601
    {
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public string RtvType { get; set; } = null!;
        public short RtvStatus { get; set; }
        public string RtvReturnStatus { get; set; } = null!;
        public string VrmaDocumentId { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public decimal SvcProcessSeqNumber { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Reference2 { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public short Decplqty { get; set; }
        public decimal Quantity { get; set; }
        public decimal Qtyshppd { get; set; }
        public decimal QtyToReceive { get; set; }
        public decimal Qtyrecvd { get; set; }
        public decimal Qtycance { get; set; }
        public string Uofm { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public string ReturnItemNumber { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Loccodeb { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string ShipAddressName { get; set; } = null!;
        public string ShipAddress1 { get; set; } = null!;
        public string ShipAddress2 { get; set; } = null!;
        public string ShipAddress3 { get; set; } = null!;
        public string ShipCity { get; set; } = null!;
        public string ShipState { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string ShipCountry { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Prmdate { get; set; }
        public DateTime PromisedTime { get; set; }
        public DateTime ShippedDate { get; set; }
        public DateTime ShippedTime { get; set; }
        public DateTime Receiptdate { get; set; }
        public DateTime ReceiptTime { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public string Ponmbrstr { get; set; } = null!;
        public decimal Polnseq { get; set; }
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string TransferReference { get; set; } = null!;
        public int Translineseq { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Eqpline { get; set; }
        public string Linitmtyp { get; set; } = null!;
        public int Lnitmseq { get; set; }
        public string BillOfLadingOut { get; set; } = null!;
        public string ShippingMethodOut { get; set; } = null!;
        public string BillOfLading { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string TrackingNumber { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Vchnumwk { get; set; } = null!;
        public string VoucherNumberInvoice { get; set; } = null!;
        public string VoucherNumberReimburse { get; set; } = null!;
        public byte Custown { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public decimal PartPrice { get; set; }
        public decimal PartCost { get; set; }
        public decimal LaborPrice { get; set; }
        public decimal LaborCost { get; set; }
        public decimal ExpensePrice { get; set; }
        public decimal ExpenseCost { get; set; }
        public decimal TravelPrice { get; set; }
        public decimal TravelCost { get; set; }
        public decimal OriginatingPartPrice { get; set; }
        public decimal OriginatingPartCost { get; set; }
        public decimal OriginatingLaborPrice { get; set; }
        public decimal OriginatingLaborCost { get; set; }
        public decimal OriginatingExpensePrice { get; set; }
        public decimal OriginatingExpenseCost { get; set; }
        public decimal OriginatingTravelPrice { get; set; }
        public decimal OriginatingTravelCost { get; set; }
        public int DexRowId { get; set; }
    }
}
