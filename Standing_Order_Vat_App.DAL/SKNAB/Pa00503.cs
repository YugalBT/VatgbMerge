using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00503
    {
        public string Paprojnumber { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public decimal Paunpostretamt { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal PaunpostedRetainerFee { get; set; }
        public decimal PapostedRetainerFee { get; set; }
        public decimal PaUnpostedBilledReten { get; set; }
        public decimal PaActualBilledRetenti { get; set; }
        public decimal Acctamnt { get; set; }
        public int DexRowId { get; set; }
    }
}
