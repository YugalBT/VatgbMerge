using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop10106
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public DateTime Usrdat01 { get; set; }
        public DateTime Usrdat02 { get; set; }
        public string Usrtab01 { get; set; } = null!;
        public string Usrtab09 { get; set; } = null!;
        public string Usrtab03 { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Comment3 { get; set; } = null!;
        public string Comment4 { get; set; } = null!;
        public int DexRowId { get; set; }
        public string Cmmttext { get; set; } = null!;
    }
}
