using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10303
    {
        public string Userid { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public short Comptrtp { get; set; }
        public string Uprtrxcd { get; set; } = null!;
        public byte Trxauflg1 { get; set; }
        public byte Trxauflg2 { get; set; }
        public byte Trxauflg3 { get; set; }
        public byte Trxauflg4 { get; set; }
        public byte Trxauflg5 { get; set; }
        public byte Trxauflg6 { get; set; }
        public byte Trxauflg7 { get; set; }
        public byte Trxauflg8 { get; set; }
        public byte Trxauflg9 { get; set; }
        public byte Trxauflg10 { get; set; }
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public int Trxhrunt { get; set; }
        public decimal Payrtamt { get; set; }
        public decimal Hrlypyrt { get; set; }
        public decimal Vardbamt { get; set; }
        public int Vardbpct { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public int Dayswrdk { get; set; }
        public string Sutastat { get; set; } = null!;
        public int Wkswrkd { get; set; }
        public decimal Shftprem { get; set; }
        public short Salchg { get; set; }
        public int DexRowId { get; set; }
    }
}
