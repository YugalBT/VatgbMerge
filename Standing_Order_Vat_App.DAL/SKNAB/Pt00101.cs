using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pt00101
    {
        public string Projname { get; set; } = null!;
        public string Projdesc { get; set; } = null!;
        public string Projmgr { get; set; } = null!;
        public string Projtype { get; set; } = null!;
        public DateTime Eststartdate { get; set; }
        public DateTime Estcompdate { get; set; }
        public DateTime Actstartdate { get; set; }
        public DateTime Actcompdate { get; set; }
        public short Projstatus { get; set; }
        public byte Closedtobill { get; set; }
        public byte Closedtocost { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Prbtadcd { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public short Estprefer { get; set; }
        public decimal Estmatcost { get; set; }
        public decimal Estlaborcost { get; set; }
        public decimal Estmisccost { get; set; }
        public decimal Estmatrev { get; set; }
        public decimal Estlaborrev { get; set; }
        public decimal Estmiscrev { get; set; }
        public decimal Actmatcost { get; set; }
        public decimal Actlaborcost { get; set; }
        public decimal Actmisccost { get; set; }
        public decimal Actmatrev { get; set; }
        public decimal Actlaborrev { get; set; }
        public decimal Actmiscrev { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
