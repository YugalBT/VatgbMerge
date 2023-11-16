using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa40202
    {
        public int Bookclassindx { get; set; }
        public string Bookid { get; set; } = null!;
        public string Assetclassid { get; set; } = null!;
        public DateTime Effectdatebegin { get; set; }
        public DateTime Effectdateend { get; set; }
        public short Depreciationmethod { get; set; }
        public short Averagingconv { get; set; }
        public short Amortizationcode { get; set; }
        public decimal Amortizationamount { get; set; }
        public short Originallifeyears { get; set; }
        public short Originallifedays { get; set; }
        public short Switchover { get; set; }
        public byte Salvageest { get; set; }
        public short Salvagepct { get; set; }
        public short Tefraflag { get; set; }
        public short Luxautoind { get; set; }
        public short InitialAllowancePerc { get; set; }
        public short Specdeprallow { get; set; }
        public short Specdeprallowpct { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public byte Luxvantruck { get; set; }
        public byte Luxelauto { get; set; }
        public int DexRowId { get; set; }
    }
}
