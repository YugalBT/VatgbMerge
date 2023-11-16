using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr30400
    {
        public string Auctrlcd { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Uswhpstd { get; set; } = null!;
        public byte Histrmvd { get; set; }
        public string Bachnumb { get; set; } = null!;
        public int Numoftrx { get; set; }
        public short Numofemp { get; set; }
        public int Cntrltrx { get; set; }
        public short Ctrlempct { get; set; }
        public byte Approvl { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public int DexRowId { get; set; }
    }
}
