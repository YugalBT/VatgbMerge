using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm00303
    {
        public string Salsterr { get; set; } = null!;
        public string Slterdsc { get; set; } = null!;
        public byte Inactive { get; set; }
        public string Slprsnid { get; set; } = null!;
        public string Stmgrfnm { get; set; } = null!;
        public string Stmgrmnm { get; set; } = null!;
        public string Stmgrlnm { get; set; } = null!;
        public string Country { get; set; } = null!;
        public decimal Costtodt { get; set; }
        public decimal Ttlcomtd { get; set; }
        public decimal Ttlcomly { get; set; }
        public decimal Ncomslyr { get; set; }
        public decimal Comsllyr { get; set; }
        public decimal Cstlstyr { get; set; }
        public decimal Comsltdt { get; set; }
        public decimal Ncomsltd { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kperhist { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public int DexRowId { get; set; }
    }
}
