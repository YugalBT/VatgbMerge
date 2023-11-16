using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30101
    {
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public short Rmdtypal { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Postdate { get; set; }
        public string Pstusrid { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public DateTime Lstedtdt { get; set; }
        public string Lstusred { get; set; } = null!;
        public decimal Ortrxamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal Costamnt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Comdlram { get; set; }
        public decimal Cashamnt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavamt { get; set; }
        public decimal Discrtnd { get; set; }
        public DateTime Discdate { get; set; }
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public decimal Wrofamnt { get; set; }
        public string Trxdscrn { get; set; } = null!;
        public string Cspornbr { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Slstercd { get; set; } = null!;
        public DateTime Dinvpdof { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public byte Delete1 { get; set; }
        public string Taxschid { get; set; } = null!;
        public string Slschdid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public decimal Trdisamt { get; set; }
        public decimal Noteindx { get; set; }
        public short Voidstts { get; set; }
        public DateTime Voiddate { get; set; }
        public string Balfwdnm { get; set; } = null!;
        public short Cshrctyp { get; set; }
        public DateTime TaxDate { get; set; }
        public byte Aplywith { get; set; }
        public DateTime Saledate { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Electronic { get; set; }
        public byte Ectrx { get; set; }
        public decimal Bktslsam { get; set; }
        public decimal BackoutTradeDisc { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public byte Factoring { get; set; }
        public byte Directdebit { get; set; }
        public int DexRowId { get; set; }
    }
}
