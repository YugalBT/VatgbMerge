using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00500
    {
        public string Custnmbr { get; set; } = null!;
        public string Crdtmgr { get; set; } = null!;
        public short PreferredContactMethod { get; set; }
        public byte Nomail { get; set; }
        public string Adrscode { get; set; } = null!;
        public short TimeZone { get; set; }
        public short CnCreditControlCycle { get; set; }
        public string Usrtab01 { get; set; } = null!;
        public string Usrtab09 { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public DateTime Usrdat01 { get; set; }
        public byte UserDefinedCb1 { get; set; }
        public byte UserDefinedCb2 { get; set; }
        public int DexRowId { get; set; }
    }
}
