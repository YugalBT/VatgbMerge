using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm10301
    {
        public short Doctype { get; set; }
        public short Rmdtypal { get; set; }
        public string Rmdnumwk { get; set; } = null!;
        public string Docnumbr { get; set; } = null!;
        public string Docprfix { get; set; } = null!;
        public string Docdescr { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public string Bachnumb { get; set; } = null!;
        public string Bchsourc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public short Comappto { get; set; }
        public decimal Comdlram { get; set; }
        public decimal Ncomamnt { get; set; }
        public string Shipmthd { get; set; } = null!;
        public string Cstponbr { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Slschdid { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public decimal Costamnt { get; set; }
        public decimal Slsamnt { get; set; }
        public decimal Trdisamt { get; set; }
        public short Trddisct { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Miscamnt { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Bktslsam { get; set; }
        public decimal Bktfrtam { get; set; }
        public decimal Bktmscam { get; set; }
        public byte Txengcld { get; set; }
        public decimal Docamnt { get; set; }
        public decimal Appldamt { get; set; }
        public decimal Cashamnt { get; set; }
        public string Cbkidcsh { get; set; } = null!;
        public DateTime Cashdate { get; set; }
        public string Dcnumcsh { get; set; } = null!;
        public decimal Chekamnt { get; set; }
        public string Cbkidchk { get; set; } = null!;
        public string Cbkidcrd { get; set; } = null!;
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Dcnumchk { get; set; } = null!;
        public decimal Crcrdamt { get; set; }
        public string Crcrdnam { get; set; } = null!;
        public string Rctnccrd { get; set; } = null!;
        public DateTime Crcarddt { get; set; }
        public string Dcnumcrd { get; set; } = null!;
        public decimal Discrtnd { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public decimal Acctamnt { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public decimal Disavamt { get; set; }
        public DateTime Discdate { get; set; }
        public DateTime Duedate { get; set; }
        public decimal Dscdlram { get; set; }
        public short Dscpctam { get; set; }
        public string Curncyid { get; set; } = null!;
        public byte Posted { get; set; }
        public DateTime Lstedtdt { get; set; }
        public string Lstusred { get; set; } = null!;
        public byte[] Rmtremsg { get; set; } = null!;
        public byte[] Rmdpemsg { get; set; } = null!;
        public DateTime Glpostdt { get; set; }
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public DateTime TaxDate { get; set; }
        public byte Aplywith { get; set; }
        public DateTime Saledate { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Corrnxst { get; set; }
        public string Docncorr { get; set; } = null!;
        public byte[] Rmtremsg2 { get; set; } = null!;
        public byte DocPrinted { get; set; }
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public byte Electronic { get; set; }
        public byte Ectrx { get; set; }
        public short Pstgstus { get; set; }
        public decimal BackoutTradeDisc { get; set; }
        public byte Directdebit { get; set; }
        public int DexRowId { get; set; }
    }
}
