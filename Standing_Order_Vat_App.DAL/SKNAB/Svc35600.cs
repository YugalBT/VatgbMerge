using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc35600
    {
        public string RtvNumber { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public string RtvReturnStatus { get; set; } = null!;
        public short RtvStatus { get; set; }
        public string VrmaDocumentId { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
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
        public string Loccodeb { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public decimal PartPrice { get; set; }
        public decimal PartCost { get; set; }
        public decimal LaborPrice { get; set; }
        public decimal LaborCost { get; set; }
        public decimal ExpensePrice { get; set; }
        public decimal ExpenseCost { get; set; }
        public decimal TravelPrice { get; set; }
        public decimal TravelCost { get; set; }
        public string BillOfLadingOut { get; set; } = null!;
        public string ShippingMethodOut { get; set; } = null!;
        public string BillOfLading { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Vchnumwk { get; set; } = null!;
        public string VoucherNumberInvoice { get; set; } = null!;
        public string VoucherNumberReimburse { get; set; } = null!;
        public byte Custown { get; set; }
        public string Userid { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
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
        public decimal OriginatingPartPrice { get; set; }
        public decimal OriginatingPartCost { get; set; }
        public decimal OriginatingLaborPrice { get; set; }
        public decimal OriginatingLaborCost { get; set; }
        public decimal OriginatingExpensePrice { get; set; }
        public decimal OriginatingExpenseCost { get; set; }
        public decimal OriginatingTravelPrice { get; set; }
        public decimal OriginatingTravelCost { get; set; }
        public short Voidstts { get; set; }
        public int DexRowId { get; set; }
    }
}
