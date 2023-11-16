using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Ahrta330
    {
        public int TrxI { get; set; }
        public short Gbtatype { get; set; }
        public string EmpidI { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public string DivisioncodeI { get; set; } = null!;
        public string TimecodeI { get; set; } = null!;
        public DateTime Trxdate { get; set; }
        public DateTime Trxenddt { get; set; }
        public short TrxerrorI { get; set; }
        public int HoursI { get; set; }
        public int HoursavailableI { get; set; }
        public int Dayswrdk { get; set; }
        public int Wkswrkd { get; set; }
        public byte Accflg { get; set; }
        public byte AccruetimebenefitsI { get; set; }
        public byte Posted { get; set; }
        public string Atttyp { get; set; } = null!;
        public string Attrsn { get; set; } = null!;
        public short Atttrxstatus { get; set; }
        public string Bachnumb { get; set; } = null!;
        public int Comptrnm { get; set; }
        public decimal Cmrecnum { get; set; }
        public string Payrcord { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public DateTime ChangetimeI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
