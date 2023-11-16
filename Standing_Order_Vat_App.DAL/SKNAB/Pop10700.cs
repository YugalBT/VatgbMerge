using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop10700
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public int Lclinenumber { get; set; }
        public int Lchdrnumber { get; set; }
        public string LandedCostId { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string LongDescription { get; set; } = null!;
        public short LandedCostType { get; set; }
        public string Vendorid { get; set; } = null!;
        public decimal VendorNoteIndex { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal CurrencyNoteIndex { get; set; }
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public short Decplcur { get; set; }
        public short Odecplcu { get; set; }
        public int Acpuridx { get; set; }
        public string DistRef { get; set; } = null!;
        public int Purpvidx { get; set; }
        public byte InvoiceMatch { get; set; }
        public short Calcmthd { get; set; }
        public decimal OrigLandedCostAmount { get; set; }
        public int CalculationPercentage { get; set; }
        public decimal TotalLandedCostAmount { get; set; }
        public decimal OrigTotalLandedCostAmt { get; set; }
        public short LandedCostWarnings { get; set; }
        public short ApportionBy { get; set; }
        public decimal OrigUnapportionedAmount { get; set; }
        public int Invindx { get; set; }
        public short Applied { get; set; }
        public int DexRowId { get; set; }
    }
}
