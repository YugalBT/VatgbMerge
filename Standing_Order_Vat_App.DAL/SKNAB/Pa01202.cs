using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01202
    {
        public string Paprojnumber { get; set; } = null!;
        public string Pamccurncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Pabratetpid { get; set; } = null!;
        public string Pabexgtblid { get; set; } = null!;
        public decimal Pabxchgrate { get; set; }
        public DateTime Pabexchdate { get; set; }
        public DateTime Pabtime1 { get; set; }
        public short Pabrtclcmtd { get; set; }
        public decimal Pabdenxrate { get; set; }
        public short Pabmctrxstt { get; set; }
        public string Pafratetpid { get; set; } = null!;
        public string Pafexgtblid { get; set; } = null!;
        public decimal Pafxchgrate { get; set; }
        public DateTime Pafexchdate { get; set; }
        public DateTime Paftime1 { get; set; }
        public short Pafrtclcmtd { get; set; }
        public decimal Pafdenxrate { get; set; }
        public short Pafmctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
