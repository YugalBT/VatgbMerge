using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm10400
    {
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Pmntnmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public short Doctype { get; set; }
        public decimal Docamnt { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Pstgdate { get; set; }
        public short Pyenttyp { get; set; }
        public decimal Chekamnt { get; set; }
        public string Cardname { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public string Trxdscrn { get; set; } = null!;
        public decimal Disamtav { get; set; }
        public decimal Distknam { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Appldamt { get; set; }
        public byte[] Pmwrkmsg { get; set; } = null!;
        public byte[] Pmwrkms2 { get; set; } = null!;
        public byte[] Pmdstmsg { get; set; } = null!;
        public decimal Gstdsamt { get; set; }
        public decimal Ppsamded { get; set; }
        public short Ppstaxrt { get; set; }
        public short Pgramsbj { get; set; }
        public decimal Noteindx { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Cntrltyp { get; set; }
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public decimal Retnagam { get; set; }
        public byte Electronic { get; set; }
        public int DexRowId { get; set; }
    }
}
