using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy70500
    {
        public short Stdpssrs { get; set; }
        public short Endpsers { get; set; }
        public string Stservid { get; set; } = null!;
        public string Endsrvid { get; set; } = null!;
        public string Finrptnm { get; set; } = null!;
        public byte Prntnots { get; set; }
        public short Prnttype { get; set; }
        public string Strtcmnm { get; set; } = null!;
        public string Strtzpcd { get; set; } = null!;
        public string Stwstnty { get; set; } = null!;
        public short Sttcateg { get; set; }
        public short Endcateg { get; set; }
        public string Endcmpnm { get; set; } = null!;
        public string Endzipcd { get; set; } = null!;
        public string Endwstyp { get; set; } = null!;
        public byte Askechtm { get; set; }
        public byte Inclgnds { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public short Rptgrind { get; set; }
        public short Rtpachin { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Sortby { get; set; }
        public short Rptypsec { get; set; }
        public string Endusrid { get; set; } = null!;
        public string Endusrnm { get; set; } = null!;
        public string Endusrcl { get; set; } = null!;
        public DateTime Endingdt { get; set; }
        public short Endtkndt { get; set; }
        public short Endfrsrs { get; set; }
        public string Sttusrid { get; set; } = null!;
        public string Sttusrnm { get; set; } = null!;
        public string Sttusrcl { get; set; } = null!;
        public DateTime Strtngdt { get; set; }
        public short Sttokndt { get; set; }
        public short Sttfmsrs { get; set; }
        public string Stcurrid { get; set; } = null!;
        public string Endcurid { get; set; } = null!;
        public string Stcurrdesc { get; set; } = null!;
        public string Endcurrdesc { get; set; } = null!;
        public string Stextabid { get; set; } = null!;
        public string Endextabid { get; set; } = null!;
        public string Stextabdesc { get; set; } = null!;
        public string Endextabdesc { get; set; } = null!;
        public string Sticid { get; set; } = null!;
        public string Endicid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
