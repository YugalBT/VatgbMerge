using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00300
    {
        public int Assetindex { get; set; }
        public int Bookindx { get; set; }
        public short Tefraflag { get; set; }
        public decimal Itcamttaken { get; set; }
        public decimal Itcamtallowed { get; set; }
        public decimal Itcrecapture { get; set; }
        public decimal Orgcostbasis { get; set; }
        public decimal Sect179expded { get; set; }
        public decimal Itccoderedamt { get; set; }
        public decimal Misccostadj { get; set; }
        public decimal Netcostbasis { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
