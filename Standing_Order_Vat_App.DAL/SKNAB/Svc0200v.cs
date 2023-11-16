using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0200v
    {
        public short Srvrectype { get; set; }
        public string Callnbr { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public string Srvstat { get; set; } = null!;
        public string? Stsdescr { get; set; }
        public string Srvtype { get; set; } = null!;
        public string Pordnmbr { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string CustomerReference { get; set; } = null!;
        public string Contnbr { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public int History { get; set; }
        public int? DexRowId { get; set; }
    }
}
