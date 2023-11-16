using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Vat10302
    {
        public short Series { get; set; }
        public short Doctype { get; set; }
        public string Docnumbr { get; set; } = null!;
        public decimal Sqncline { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Tcc { get; set; } = null!;
        public decimal Numass { get; set; }
        public decimal Quantity { get; set; }
        public decimal Lmass { get; set; }
        public string Tmcode { get; set; } = null!;
        public string Transnature { get; set; } = null!;
        public decimal Suppunits { get; set; }
        public string Tradref { get; set; } = null!;
        public decimal Goodsvalue { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime TaxDate { get; set; }
        public DateTime ReferenceDate { get; set; }
        public byte Posted { get; set; }
        public short Voidstts { get; set; }
        public decimal Orgdsval { get; set; }
        public decimal Ortaxamt { get; set; }
        public short Currnidx { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Prt { get; set; } = null!;
        public string Rgn { get; set; } = null!;
        public string Cntryorgn { get; set; } = null!;
        public string Prcdrrgm { get; set; } = null!;
        public string Inctrms { get; set; } = null!;
        public decimal Sttstclvl { get; set; }
        public decimal Orgntngsttstclvl { get; set; }
        public byte IncludedOnReturn { get; set; }
        public string Intrsttrtrnid { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Arrdisp { get; set; } = null!;
        public string Period { get; set; } = null!;
        public string Audittrail { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
