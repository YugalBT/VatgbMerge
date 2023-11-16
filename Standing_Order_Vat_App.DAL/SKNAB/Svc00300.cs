using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00300
    {
        public int Equipid { get; set; }
        public string Serlnmbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Refrence { get; set; } = null!;
        public string Version { get; set; } = null!;
        public string Srlstat { get; set; } = null!;
        public DateTime Instdte { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public DateTime Lstpmdte { get; set; }
        public DateTime Lstsrvdte { get; set; }
        public string Techid { get; set; } = null!;
        public string Techid2 { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Svcarea { get; set; } = null!;
        public string Timezone { get; set; } = null!;
        public string Warrcde { get; set; } = null!;
        public DateTime Warrend { get; set; }
        public DateTime Warrstart { get; set; }
        public string Slrwarr { get; set; } = null!;
        public DateTime Slrwend { get; set; }
        public DateTime Slrwstart { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Mttr { get; set; }
        public decimal Mtbf { get; set; }
        public decimal Mtbi { get; set; }
        public DateTime LastCalcDate { get; set; }
        public int Meters1 { get; set; }
        public int Meters2 { get; set; }
        public int Meters3 { get; set; }
        public int Meters4 { get; set; }
        public int Meters5 { get; set; }
        public decimal Dailys1 { get; set; }
        public decimal Dailys2 { get; set; }
        public decimal Dailys3 { get; set; }
        public decimal Dailys4 { get; set; }
        public decimal Dailys5 { get; set; }
        public decimal Mtbfs1 { get; set; }
        public decimal Mtbfs2 { get; set; }
        public decimal Mtbfs3 { get; set; }
        public decimal Mtbfs4 { get; set; }
        public decimal Mtbfs5 { get; set; }
        public int MeterDeltas1 { get; set; }
        public int MeterDeltas2 { get; set; }
        public int MeterDeltas3 { get; set; }
        public int MeterDeltas4 { get; set; }
        public int MeterDeltas5 { get; set; }
        public short SvcPmDate { get; set; }
        public short SvcPmDay { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string SvcSerialId { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string SvcAssetTag { get; set; } = null!;
        public DateTime ShippedDate { get; set; }
        public DateTime SvcRegisterDate { get; set; }
        public int DexRowId { get; set; }
    }
}
