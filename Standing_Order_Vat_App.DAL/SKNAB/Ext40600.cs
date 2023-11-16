using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ext40600
    {
        public string WarningId { get; set; } = null!;
        public string WarningDescription { get; set; } = null!;
        public string WarningPrompt { get; set; } = null!;
        public short WarningType { get; set; }
        public byte TrackResponses { get; set; }
        public string ButtonPrompts1 { get; set; } = null!;
        public string ButtonPrompts2 { get; set; } = null!;
        public string ButtonPrompts3 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
