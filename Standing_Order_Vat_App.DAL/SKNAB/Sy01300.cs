using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy01300
    {
        public short ProcessId { get; set; }
        public short Prodid { get; set; }
        public short LanguageId { get; set; }
        public short Dpseries { get; set; }
        public short LoadFactor { get; set; }
        public string ServiceName { get; set; } = null!;
        public short Priority { get; set; }
        public DateTime QueueTime { get; set; }
        public DateTime QueueDate { get; set; }
        public short RecurranceInterval { get; set; }
        public string ScriptName { get; set; } = null!;
        public byte Deletable { get; set; }
        public byte DeletableWhenRunning { get; set; }
        public byte Remote { get; set; }
        public string BeginGroupProcessName { get; set; } = null!;
        public byte Trkpsatv { get; set; }
        public string ServerNotifyScriptName { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
