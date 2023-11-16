using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop30310
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Ponumber { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public string Vnditdsc { get; set; } = null!;
        public decimal Umqtyinb { get; set; }
        public DateTime Actlship { get; set; }
        public string Commntid { get; set; } = null!;
        public int Invindx { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Unitcost { get; set; }
        public decimal Extdcost { get; set; }
        public string Locncode { get; set; } = null!;
        public decimal RcptLineNoteIdarray1 { get; set; }
        public decimal RcptLineNoteIdarray2 { get; set; }
        public decimal RcptLineNoteIdarray3 { get; set; }
        public decimal RcptLineNoteIdarray4 { get; set; }
        public decimal RcptLineNoteIdarray5 { get; set; }
        public decimal RcptLineNoteIdarray6 { get; set; }
        public decimal RcptLineNoteIdarray7 { get; set; }
        public decimal RcptLineNoteIdarray8 { get; set; }
        public short Noninven { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public short Itmtrkop { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Jobnumbr { get; set; } = null!;
        public string Costcode { get; set; } = null!;
        public short Costtype { get; set; }
        public short Currnidx { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal Orextcst { get; set; }
        public short Odecplcu { get; set; }
        public string Bolpronumber { get; set; } = null!;
        public byte CapitalItem { get; set; }
        public short ProductIndicator { get; set; }
        public short PurchaseIvItemTaxable { get; set; }
        public string PurchaseItemTaxSchedu { get; set; } = null!;
        public string PurchaseSiteTaxSchedu { get; set; } = null!;
        public byte Bsivcttl { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Bcktxamt { get; set; }
        public decimal Obtaxamt { get; set; }
        public int Purpvidx { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string LandedCostGroupId { get; set; } = null!;
        public short LandedCostWarnings { get; set; }
        public byte LandedCost { get; set; }
        public byte InvoiceMatch { get; set; }
        public string Rcptretnum { get; set; } = null!;
        public int Rcptretlnnum { get; set; }
        public string Invretnum { get; set; } = null!;
        public int Invretlnnum { get; set; }
        public byte Islineintra { get; set; }
        public string ProjNum { get; set; } = null!;
        public string CostCatId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
