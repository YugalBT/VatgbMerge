using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy03000
    {
        public string Shipmthd { get; set; } = null!;
        public string Shmthdsc { get; set; } = null!;
        public string Phonname { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Carracct { get; set; } = null!;
        public string Carrier { get; set; } = null!;
        public short Shiptype { get; set; }
        public decimal Noteindx { get; set; }
        public string Lstusred { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
