using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00100
    {
        public int Assetindex { get; set; }
        public string Assetid { get; set; } = null!;
        public short Assetidsuf { get; set; }
        public string Shrtname { get; set; } = null!;
        public string Assetdesc { get; set; } = null!;
        public string Extassetdesc { get; set; } = null!;
        public string MasterAssetId { get; set; } = null!;
        public string Structureid { get; set; } = null!;
        public string Assetclassid { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public DateTime Acqdate { get; set; }
        public decimal AcquisitionCost { get; set; }
        public short Assettype { get; set; }
        public short Assetstatus { get; set; }
        public short Proptype { get; set; }
        public int Assetqty { get; set; }
        public int Assetbegqty { get; set; }
        public decimal Assetcurrmaint { get; set; }
        public decimal Assetytdmaint { get; set; }
        public decimal Assetltdmaint { get; set; }
        public DateTime Lastmaintdate { get; set; }
        public decimal Assessedvalue { get; set; }
        public string Mfgrname { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string Modelnumber { get; set; } = null!;
        public DateTime Warrentydate { get; set; }
        public string Custodian { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public DateTime Dateadded { get; set; }
        public DateTime Deletedate { get; set; }
        public string PhysicalLocationId { get; set; } = null!;
        public string AssetLabel { get; set; } = null!;
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; } = null!;
        public int Lastpurchlineseq { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
