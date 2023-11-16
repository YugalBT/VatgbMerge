using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc0202v
    {
        public int Equipid { get; set; }
        public int Eqpline { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Callnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public string Techid { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public string Probcde { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Srvstat { get; set; } = null!;
        public string Contnbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public int? DexRowId { get; set; }
    }
}
