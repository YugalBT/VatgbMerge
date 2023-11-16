using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm10201
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public DateTime Docdate { get; set; }
        public short Cshrctyp { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Crcardid { get; set; } = null!;
        public decimal Disamchk { get; set; }
        public string Curncyid { get; set; } = null!;
        public decimal Ndstamnt { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public short Onhold { get; set; }
        public byte Posted { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lstedtdt { get; set; }
        public string Lstusred { get; set; } = null!;
        public decimal Ortrxamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public byte[] Rmtremsg { get; set; } = null!;
        public byte[] Rmdpemsg { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public byte[] Rmtremsg2 { get; set; } = null!;
        public short Pstgstus { get; set; }
        public int DexRowId { get; set; }
    }
}
