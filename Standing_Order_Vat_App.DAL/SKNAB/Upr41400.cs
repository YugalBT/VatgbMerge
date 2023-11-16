using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41400
    {
        public string Localtax { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Lcltxcal1 { get; set; }
        public short Lcltxcal2 { get; set; }
        public short Lcltxcal3 { get; set; }
        public short Lcltxcal4 { get; set; }
        public short Lcltxcal5 { get; set; }
        public decimal Exmtamnt { get; set; }
        public decimal Mntxblwg { get; set; }
        public decimal Mytdtxwg { get; set; }
        public int Lcltaxrt { get; set; }
        public decimal Lcltxamt { get; set; }
        public decimal Maxperyr { get; set; }
        public byte Inactive { get; set; }
        public decimal Noteindx { get; set; }
        public short Stddmthd { get; set; }
        public int Stddpcnt { get; set; }
        public decimal Stddedam { get; set; }
        public decimal Stdedmax { get; set; }
        public decimal Stdedmin { get; set; }
        public short Taxtype { get; set; }
        public int DexRowId { get; set; }
    }
}
