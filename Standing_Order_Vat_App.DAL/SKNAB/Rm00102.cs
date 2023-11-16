using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00102
    {
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Upszone { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public string Gpsfointegrationid { get; set; } = null!;
        public short Integrationsource { get; set; }
        public string Integrationid { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
