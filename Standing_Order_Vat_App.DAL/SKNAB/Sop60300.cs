using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop60300
    {
        public string Itemnmbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custitemnmbr { get; set; } = null!;
        public string Custitemdesc { get; set; } = null!;
        public string Custitemshorname { get; set; } = null!;
        public string Custitemgenericdesc { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string Userdefkey1 { get; set; } = null!;
        public string Userdefkey2 { get; set; } = null!;
        public string Userdefkey3 { get; set; } = null!;
        public string Userdefkey4 { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
