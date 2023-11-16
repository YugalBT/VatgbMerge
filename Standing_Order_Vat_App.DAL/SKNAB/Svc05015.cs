using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05015
    {
        public string Userid { get; set; } = null!;
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short RmaStatus { get; set; }
        public string Techid { get; set; } = null!;
        public string Rettype { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public decimal Quantity { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string ReturnItemNumber { get; set; } = null!;
        public decimal ReturnQty { get; set; }
        public string Locncode { get; set; } = null!;
        public string Binnmbr { get; set; } = null!;
        public string Orddocid { get; set; } = null!;
        public string Callnbr { get; set; } = null!;
        public string Retref { get; set; } = null!;
        public byte CbPackingSlip { get; set; }
        public byte Chdflag { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string ReturnUOfM { get; set; } = null!;
        public short Decplqty { get; set; }
        public int DexRowId { get; set; }
    }
}
