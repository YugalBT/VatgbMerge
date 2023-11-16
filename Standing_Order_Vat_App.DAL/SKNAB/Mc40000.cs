using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc40000
    {
        public string Funlcurr { get; set; } = null!;
        public short Funcridx { get; set; }
        public string Rptgcurr { get; set; } = null!;
        public short Rptcridx { get; set; }
        public decimal Rptxrate { get; set; }
        public short Rprtclmd { get; set; }
        public byte Alownwrt { get; set; }
        public string Anwrtpwd { get; set; } = null!;
        public byte Alwmodrt { get; set; }
        public string Modrtpwd { get; set; } = null!;
        public byte Alovexrt { get; set; }
        public string Ovxrtpwd { get; set; } = null!;
        public byte Aovrtvar { get; set; }
        public string Ovrtvpwd { get; set; } = null!;
        public byte Aovrptrt { get; set; }
        public string Ovrprpwd { get; set; } = null!;
        public short Avgexrat { get; set; }
        public string Deffintp { get; set; } = null!;
        public string Defslstp { get; set; } = null!;
        public string Defpurtp { get; set; } = null!;
        public byte Mnsumhst { get; set; }
        public DateTime Lstreval { get; set; }
        public DateTime Lstprval { get; set; }
        public DateTime Lstsrval { get; set; }
        public DateTime Lsttrxrv { get; set; }
        public DateTime Lstsumrv { get; set; }
        public int DexRowId { get; set; }
    }
}
