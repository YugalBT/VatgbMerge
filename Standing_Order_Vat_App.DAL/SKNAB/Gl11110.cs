using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Gl11110
    {
        public short Year1 { get; set; }
        public short Periodid { get; set; }
        public decimal Perdblnc { get; set; }
        public decimal Crdtamnt { get; set; }
        public decimal Debitamt { get; set; }
        public int Actindx { get; set; }
        public string Actnumbr1 { get; set; } = null!;
        public string Actnumbr2 { get; set; } = null!;
        public string Actnumbr3 { get; set; } = null!;
        public string Actnumbr4 { get; set; } = null!;
        public string Actnumbr5 { get; set; } = null!;
        public string Actnumbr6 { get; set; } = null!;
        public string Actnumbr7 { get; set; } = null!;
        public string Actnumbr8 { get; set; } = null!;
        public string Actnumbr9 { get; set; } = null!;
        public string Actnumbr10 { get; set; } = null!;
        public string Actalias { get; set; } = null!;
        public string Mnacsgmt { get; set; } = null!;
        public short Accttype { get; set; }
        public string Actdescr { get; set; } = null!;
        public short Pstngtyp { get; set; }
        public short Accatnum { get; set; }
        public byte Active { get; set; }
        public short Tpclblnc { get; set; }
        public short Decplacs { get; set; }
        public short Fxdorvar { get; set; }
        public short Balfrclc { get; set; }
        public byte[] Dsplkups { get; set; } = null!;
        public short Cnvrmthd { get; set; }
        public decimal Hstrclrt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public short PostSlsIn { get; set; }
        public short PostIvIn { get; set; }
        public short PostPurchIn { get; set; }
        public short PostPrin { get; set; }
        public byte Adjinfl { get; set; }
        public int Inflarev { get; set; }
        public int Inflaequ { get; set; }
        public byte Acctentr { get; set; }
        public string Usrdefs1 { get; set; } = null!;
        public string Usrdefs2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
