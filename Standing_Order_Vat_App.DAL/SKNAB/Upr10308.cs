using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10308
    {
        public short Mlchktyp { get; set; }
        public int Pyadnmbr { get; set; }
        public string Employid { get; set; } = null!;
        public int Mltrxnbr { get; set; }
        public short Mltrxtyp { get; set; }
        public string Uprtrxcd { get; set; } = null!;
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public decimal Hrlypyrt { get; set; }
        public decimal Mltrxamt { get; set; }
        public int Mltrxhrs { get; set; }
        public decimal Txblwags { get; set; }
        public decimal Receipts { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public decimal Noteindx { get; set; }
        public string Shftcode { get; set; } = null!;
        public decimal Shftprem { get; set; }
        public int DexRowId { get; set; }
    }
}
