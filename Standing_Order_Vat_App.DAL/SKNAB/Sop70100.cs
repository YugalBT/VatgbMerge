using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop70100
    {
        public string Inqid { get; set; } = null!;
        public byte History { get; set; }
        public byte Unpsttrx { get; set; }
        public short Sortby { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string User2ent { get; set; } = null!;
        public string Stcustid { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Stcustnm { get; set; } = null!;
        public string Encstnam { get; set; } = null!;
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public string Stdocnum { get; set; } = null!;
        public string Endocnum { get; set; } = null!;
        public short Stsoptyp { get; set; }
        public short Edsoptyp { get; set; }
        public string Sttdocid { get; set; } = null!;
        public string Enddocid { get; set; } = null!;
        public string Sttitnum { get; set; } = null!;
        public string Enitmnbr { get; set; } = null!;
        public int Stmstnmb { get; set; }
        public int Edmasnmb { get; set; }
        public string Sttphon1 { get; set; } = null!;
        public string Endphon1 { get; set; } = null!;
        public DateTime Stquoexd { get; set; }
        public DateTime Edquoexd { get; set; }
        public DateTime Streqdat { get; set; }
        public DateTime Endreqdt { get; set; }
        public string Stsprsid { get; set; } = null!;
        public string Enspsnid { get; set; } = null!;
        public string Sttudef1 { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public short StartPurchasingStatus { get; set; }
        public short EndPurchasingStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
