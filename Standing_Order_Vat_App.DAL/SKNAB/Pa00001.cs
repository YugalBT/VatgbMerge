using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00001
    {
        public string Custnmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Ratetpid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public int DexRowId { get; set; }
    }
}
