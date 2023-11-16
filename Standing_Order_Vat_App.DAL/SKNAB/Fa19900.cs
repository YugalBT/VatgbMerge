using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa19900
    {
        public int Assetindex { get; set; }
        public string Usrfield1 { get; set; } = null!;
        public string Usrfield2 { get; set; } = null!;
        public string Usrfield3 { get; set; } = null!;
        public string Usrfield4 { get; set; } = null!;
        public string Usrfield5 { get; set; } = null!;
        public string Usrfield6 { get; set; } = null!;
        public string Usrfield7 { get; set; } = null!;
        public string Usrfield8 { get; set; } = null!;
        public string Usrfield9 { get; set; } = null!;
        public string Usrfield10 { get; set; } = null!;
        public decimal Usrfield11 { get; set; }
        public decimal Usrfield12 { get; set; }
        public decimal Usrfield13 { get; set; }
        public decimal Usrfield14 { get; set; }
        public decimal Usrfield15 { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
