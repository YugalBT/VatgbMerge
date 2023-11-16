using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr30300
    {
        public decimal Cmrecnum { get; set; }
        public string Auctrlcd { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public int Pyadnmbr { get; set; }
        public short Year1 { get; set; }
        public DateTime Chekdate { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public short Pyrlrtyp { get; set; }
        public string Payrolcd { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public short Doctype { get; set; }
        public string Jobtitle { get; set; } = null!;
        public DateTime Trxbegdt { get; set; }
        public DateTime Trxenddt { get; set; }
        public decimal Untstopy { get; set; }
        public decimal Payrate { get; set; }
        public decimal Uprtrxam { get; set; }
        public short TimetypeI { get; set; }
        public decimal Timeavailable { get; set; }
        public short TipType { get; set; }
        public decimal Receipts { get; set; }
        public decimal Payadvnc { get; set; }
        public string Statecd { get; set; } = null!;
        public string Localtax { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public string Uswhpstd { get; set; } = null!;
        public DateTime Lstdtedt { get; set; }
        public string Lastuser { get; set; } = null!;
        public string Shftcode { get; set; } = null!;
        public decimal Shftprem { get; set; }
        public decimal Txblwags { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public string Sutastat { get; set; } = null!;
        public byte Sbjtfuta { get; set; }
        public decimal Bsdonrte { get; set; }
        public string Emplclas { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
