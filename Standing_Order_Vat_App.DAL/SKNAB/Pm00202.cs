using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00202
    {
        public string Vendorid { get; set; } = null!;
        public short Periodid { get; set; }
        public short Year1 { get; set; }
        public short Histtype { get; set; }
        public decimal Ambldlif { get; set; }
        public decimal Amtpdlif { get; set; }
        public decimal Ten99alif { get; set; }
        public decimal Disavlif { get; set; }
        public decimal Distknlf { get; set; }
        public decimal Dislstlf { get; set; }
        public decimal Finchlif { get; set; }
        public decimal Wrofslif { get; set; }
        public decimal Rtrnslif { get; set; }
        public decimal Trdtklif { get; set; }
        public int Nfnchlif { get; set; }
        public int Noinvlif { get; set; }
        public decimal WithholdingLife { get; set; }
        public int DexRowId { get; set; }
    }
}
