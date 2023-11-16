using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Af40102
    {
        public short Reportid { get; set; }
        public short Hdrftrty { get; set; }
        public short Fldnum { get; set; }
        public short Fldposx1 { get; set; }
        public short Fldposy1 { get; set; }
        public short Fldposx2 { get; set; }
        public short Fldposy2 { get; set; }
        public short Fldtype { get; set; }
        public short Fldfrmat { get; set; }
        public short Sbhsbfin { get; set; }
        public short Fldopt { get; set; }
        public short Fldopt2 { get; set; }
        public short Fldalign { get; set; }
        public short Fldftfml { get; set; }
        public short Fldftsiz { get; set; }
        public short Fldstyle1 { get; set; }
        public short Fldstyle2 { get; set; }
        public short Fldstyle3 { get; set; }
        public short Fldstyle4 { get; set; }
        public short Fldstyle5 { get; set; }
        public short Fldstyle6 { get; set; }
        public string Fldvalue { get; set; } = null!;
        public string Fldvalu2 { get; set; } = null!;
        public string Fldprnam { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
