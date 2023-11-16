using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Me142803
    {
        public string Mebankid { get; set; } = null!;
        public string Mebankdesc { get; set; } = null!;
        public short MeFileType { get; set; }
        public string MeDelimiter { get; set; } = null!;
        public short MeRecordLength { get; set; }
        public short MeFromPosition { get; set; }
        public short MeToPosition { get; set; }
        public short MeFieldNumber { get; set; }
        public byte MeUsesStatusCodes { get; set; }
        public DateTime Userdate { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
