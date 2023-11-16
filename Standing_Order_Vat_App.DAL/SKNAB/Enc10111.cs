using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10111
    {
        public string Ponumber { get; set; } = null!;
        public int Polnenum { get; set; }
        public short Polnesta { get; set; }
        public short Encbstat { get; set; }
        public decimal Encmbamt { get; set; }
        public byte Liquidat { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public short Noninven { get; set; }
        public int Invindx { get; set; }
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public string Uofm { get; set; } = null!;
        public decimal Umqtyinb { get; set; }
        public decimal Qtyorder { get; set; }
        public decimal Qtycance { get; set; }
        public short Decplcur { get; set; }
        public short Decplqty { get; set; }
        public decimal Unitcost { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Reqdate { get; set; }
        public DateTime Docdate { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public short Lineorigin { get; set; }
        public short Potype { get; set; }
        public short LineNumber { get; set; }
        public int AaDimId { get; set; }
        public int AaTrxDimId { get; set; }
        public int DexRowId { get; set; }
    }
}
