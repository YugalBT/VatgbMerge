using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00801
    {
        public int Transferindx { get; set; }
        public int Transferevent { get; set; }
        public int Assetindex { get; set; }
        public string Assetid { get; set; } = null!;
        public DateTime Xfrdatestamp { get; set; }
        public DateTime Xfrtimestamp { get; set; }
        public short Transferseq { get; set; }
        public DateTime Transferdate { get; set; }
        public int Fromassetindx { get; set; }
        public string Fromassetid { get; set; } = null!;
        public string Fromstruc { get; set; } = null!;
        public string Fromloc { get; set; } = null!;
        public string FromPhysicalLocationId { get; set; } = null!;
        public string FromMasterAssetId { get; set; } = null!;
        public int Fromdeprexpacctindx { get; set; }
        public int Fromdeprresvacctindx { get; set; }
        public int Frompryrdepracctindx { get; set; }
        public int Fromassetcostacctindx { get; set; }
        public int Fromproceedsacctindx { get; set; }
        public int Fromrecgainlossacctindx { get; set; }
        public int Fromnonrecgainlossacctindx { get; set; }
        public int Fromclearacctindx { get; set; }
        public int Partialqty { get; set; }
        public decimal Partialcost { get; set; }
        public short Partialpct { get; set; }
        public int Toassetindx { get; set; }
        public string Toassetid { get; set; } = null!;
        public string Tostruc { get; set; } = null!;
        public string Toloc { get; set; } = null!;
        public string ToPhysicalLocationId { get; set; } = null!;
        public string ToMasterAssetId { get; set; } = null!;
        public int Todeprexpacctindx { get; set; }
        public int Todeprresvacctindx { get; set; }
        public int Topryrdepracctindx { get; set; }
        public int Toassetcostacctindx { get; set; }
        public int Toproceedsacctindx { get; set; }
        public int Torecgainlossacctindx { get; set; }
        public int Tononrecgainlossacctindx { get; set; }
        public int Toclearacctindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
