using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00301
    {
        public string Slprsnid { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Slprsnfn { get; set; } = null!;
        public string Sprsnsmn { get; set; } = null!;
        public string Sprsnsln { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Phone2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Fax { get; set; } = null!;
        public byte Inactive { get; set; }
        public string Salsterr { get; set; } = null!;
        public string Commcode { get; set; } = null!;
        public short Comprcnt { get; set; }
        public short Stdcprct { get; set; }
        public short Comappto { get; set; }
        public decimal Costtodt { get; set; }
        public decimal Cstlstyr { get; set; }
        public decimal Ttlcomtd { get; set; }
        public decimal Ttlcomly { get; set; }
        public decimal Comsltdt { get; set; }
        public decimal Comsllyr { get; set; }
        public decimal Ncomsltd { get; set; }
        public decimal Ncomslyr { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kperhist { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public short Commdest { get; set; }
        public int DexRowId { get; set; }
    }
}
