using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr30200
    {
        public string Auctrlcd { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public decimal Ftxwhlty { get; set; }
        public decimal Ficasstl { get; set; }
        public decimal Ficamtwl { get; set; }
        public decimal UncollectedFicassTaxP { get; set; }
        public decimal UncollectedFicamedTaxP { get; set; }
        public decimal Adeicpmt { get; set; }
        public int DexRowId { get; set; }
    }
}
