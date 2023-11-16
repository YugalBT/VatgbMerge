using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc06100
    {
        public short Worectype { get; set; }
        public string Workordnum { get; set; } = null!;
        public string Wostat { get; set; } = null!;
        public string Wotype { get; set; } = null!;
        public decimal SvcDepotPriority { get; set; }
        public short Parworectype { get; set; }
        public string Parwonum { get; set; } = null!;
        public short Origin { get; set; }
        public string Refrence { get; set; } = null!;
        public string Timezone { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Ecompdt { get; set; }
        public DateTime EcompTime { get; set; }
        public DateTime Retudate { get; set; }
        public DateTime ReturnTime { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public string Bin { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public int Servlitemseq { get; set; }
        public string Ibitemnum { get; set; } = null!;
        public string Ibserial { get; set; } = null!;
        public int Ibequipid { get; set; }
        public string Obitemnum { get; set; } = null!;
        public string Obserial { get; set; } = null!;
        public int Obequipid { get; set; }
        public decimal Quantity { get; set; }
        public string Stationid { get; set; } = null!;
        public string Routeid { get; set; } = null!;
        public decimal Sequence1 { get; set; }
        public string Locncode { get; set; } = null!;
        public string Ibanalcode { get; set; } = null!;
        public string Obanalcode { get; set; } = null!;
        public byte Custown { get; set; }
        public string Orddocid { get; set; } = null!;
        public int Translineseq { get; set; }
        public decimal Noteindx { get; set; }
        public byte Factseal { get; set; }
        public decimal Labstotcst { get; set; }
        public decimal Parstotcst { get; set; }
        public decimal Totlabhrs { get; set; }
        public string Pricelvl { get; set; } = null!;
        public short Numresched { get; set; }
        public DateTime CommitDate { get; set; }
        public DateTime CommitTime { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string SvcRmaReasonCode { get; set; } = null!;
        public string SvcRmaReasonCodeDesc { get; set; } = null!;
        public decimal SvcProcessSeqNumber { get; set; }
        public int DexRowId { get; set; }
    }
}
