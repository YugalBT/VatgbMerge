using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa12000
    {
        public string Pachgordno { get; set; } = null!;
        public byte Pacreateaddfly { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public DateTime Padocdt { get; set; }
        public string Pacodesc { get; set; } = null!;
        public string Pacocustno { get; set; } = null!;
        public short Pacotype { get; set; }
        public short Pacostatus { get; set; }
        public string Reqstdby { get; set; } = null!;
        public string Paestby { get; set; } = null!;
        public string Parevby { get; set; } = null!;
        public string Parevposition { get; set; } = null!;
        public DateTime Palstrevsedate { get; set; }
        public string Lstusred { get; set; } = null!;
        public DateTime Paprevbegindt { get; set; }
        public DateTime Pabegindate { get; set; }
        public DateTime Paprevenddt { get; set; }
        public DateTime PaenDate { get; set; }
        public string Paapprovby { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public DateTime Apprvldt { get; set; }
        public short Pagbtrkchg { get; set; }
        public decimal Parevsbudgmt { get; set; }
        public decimal Pacorevsfeeamt { get; set; }
        public decimal Patotchgordamt { get; set; }
        public decimal Paprevprojamt { get; set; }
        public decimal Pavarprofamt { get; set; }
        public decimal Parevprojamt { get; set; }
        public decimal PaprojectAmount { get; set; }
        public string Parevreason { get; set; } = null!;
        public short Padocstatus { get; set; }
        public short Pasequencenumber { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Noteindx2 { get; set; }
        public decimal Pacototcost { get; set; }
        public decimal Pacototbill { get; set; }
        public decimal Pacototqty { get; set; }
        public decimal Pavartotbillings { get; set; }
        public decimal Pavartotcost { get; set; }
        public decimal Pavartotqty { get; set; }
        public int DexRowId { get; set; }
    }
}
