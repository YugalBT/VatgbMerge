using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rv020121
    {
        public string ReviewsetupcodeI { get; set; } = null!;
        public string ReviewsetupnameI { get; set; } = null!;
        public short ReviewpreferencesI { get; set; }
        public short ReviewrangeI { get; set; }
        public byte PosttotodoI { get; set; }
        public short TotalweightI { get; set; }
        public short RevintervalprefsI { get; set; }
        public short UsewordsgbI { get; set; }
        public int DexRowId { get; set; }
    }
}
