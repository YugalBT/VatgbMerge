using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa01100
    {
        public int FaApPostIndex { get; set; }
        public byte Marked { get; set; }
        public short Faprimary { get; set; }
        public short Cntrltyp { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Orappamt { get; set; }
        public int PurchasedQuantity { get; set; }
        public int AppliedQuantity { get; set; }
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
        public decimal OrigAcquisitionCost { get; set; }
        public short Assettype { get; set; }
        public short Proptype { get; set; }
        public int Assetqty { get; set; }
        public int Assetbegqty { get; set; }
        public decimal Assetcurrmaint { get; set; }
        public decimal Assetytdmaint { get; set; }
        public decimal Assetltdmaint { get; set; }
        public DateTime Lastmaintdate { get; set; }
        public decimal Assessedvalue { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Trxsorce { get; set; } = null!;
        public string Orctrnum { get; set; } = null!;
        public string Pordnmbr { get; set; } = null!;
        public string PoLine { get; set; } = null!;
        public string Mfgrname { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string Modelnumber { get; set; } = null!;
        public DateTime Warrentydate { get; set; }
        public string Custodian { get; set; } = null!;
        public DateTime Dateadded { get; set; }
        public DateTime Deletedate { get; set; }
        public string PhysicalLocationId { get; set; } = null!;
        public string AssetLabel { get; set; } = null!;
        public DateTime VerifiedDate { get; set; }
        public string Pin { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Exgtblid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public short Rtclcmtd { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
