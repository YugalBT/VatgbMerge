using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pp50101
    {
        public string Userid { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public int Jrnentry { get; set; }
        public decimal Sqncline { get; set; }
        public int Actindx { get; set; }
        public int Offindx { get; set; }
        public decimal Trxamnt { get; set; }
        public byte[] Gllinmsg { get; set; } = null!;
        public byte[] Gllinms2 { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public short Accttype { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public short Funcridx { get; set; }
        public decimal Origamt { get; set; }
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public int DexRowId { get; set; }
    }
}
