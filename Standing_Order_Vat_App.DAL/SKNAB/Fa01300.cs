using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa01300
    {
        public string Poprctnm { get; set; } = null!;
        public int Rcptlnnm { get; set; }
        public string Assetid { get; set; } = null!;
        public short Assetidsuf { get; set; }
        public string Shrtname { get; set; } = null!;
        public string Extassetdesc { get; set; } = null!;
        public string MasterAssetId { get; set; } = null!;
        public string Structureid { get; set; } = null!;
        public string Assetclassid { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public short Assettype { get; set; }
        public short Proptype { get; set; }
        public byte CreateMultipleFixedAs { get; set; }
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
        public string PhysicalLocationId { get; set; } = null!;
        public string AssetLabel { get; set; } = null!;
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; } = null!;
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
