using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10101
    {
        public short Rptngyr { get; set; }
        public byte Mcrqgemp { get; set; }
        public string Deprtmnt { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Midlname { get; set; } = null!;
        public int Seqnumbr { get; set; }
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public byte ForeignAddress { get; set; }
        public string ForeignStateProvince { get; set; } = null!;
        public string ForeignPostalCode { get; set; } = null!;
        public string Ccode { get; set; } = null!;
        public string W2ctrnbr { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Socscnum { get; set; } = null!;
        public byte W2bfstem { get; set; }
        public byte W2bfdcsd { get; set; }
        public byte W2bfppln { get; set; }
        public byte W2bflrep { get; set; }
        public byte W2bf942e { get; set; }
        public string W2bfsttl { get; set; } = null!;
        public byte W2bfdcmp { get; set; }
        public decimal Wgtpcomp { get; set; }
        public decimal Feditxwh { get; set; }
        public decimal Ssecwags { get; set; }
        public decimal Sstxwhld { get; set; }
        public decimal Mcrwgtps { get; set; }
        public decimal Mdcrtxwh { get; set; }
        public decimal Ssectips { get; set; }
        public decimal Aloctips { get; set; }
        public decimal Adeicpmt { get; set; }
        public decimal Depcrbft { get; set; }
        public decimal Nqlfplns { get; set; }
        public decimal Bnincwgs { get; set; }
        public int W2frmctr { get; set; }
        public decimal Noteindx { get; set; }
        public string Stringarray1 { get; set; } = null!;
        public string Stringarray2 { get; set; } = null!;
        public string Stringarray3 { get; set; } = null!;
        public string Stringarray4 { get; set; } = null!;
        public string Stringarray5 { get; set; } = null!;
        public int Longintarray1 { get; set; }
        public int Longintarray2 { get; set; }
        public int Longintarray3 { get; set; }
        public int Longintarray4 { get; set; }
        public int Longintarray5 { get; set; }
        public int DexRowId { get; set; }
    }
}
