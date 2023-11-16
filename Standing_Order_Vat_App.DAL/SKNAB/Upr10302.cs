using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10302
    {
        public int Comptrnm { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public short Comptrtp { get; set; }
        public short Salchg { get; set; }
        public string Uprtrxcd { get; set; } = null!;
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public int Trxhrunt { get; set; }
        public decimal Hrlypyrt { get; set; }
        public decimal Payrtamt { get; set; }
        public decimal Vardbamt { get; set; }
        public int Vardbpct { get; set; }
        public decimal Receipts { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public string Lastuser { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Trxsorce { get; set; } = null!;
        public short Doctype { get; set; }
        public byte Voided { get; set; }
        public decimal Noteindx { get; set; }
        public byte Inaddntosal { get; set; }
        public string Shftcode { get; set; } = null!;
        public decimal Shftprem { get; set; }
        public string Jobnumbr { get; set; } = null!;
        public string Unioncd { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
