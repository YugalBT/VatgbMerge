using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc40500
    {
        public int Baruleid { get; set; }
        public string Dscriptn { get; set; } = null!;
        public string Busalrtid { get; set; } = null!;
        public string Emailmsg { get; set; } = null!;
        public int Lstrwchkd { get; set; }
        public byte Incldrslts { get; set; }
        public string Dbname { get; set; } = null!;
        public short Cmpanyid { get; set; }
        public short Freqtype { get; set; }
        public short Freqint { get; set; }
        public short Frqsubtyp { get; set; }
        public short Frqsubint { get; set; }
        public short Frqrelint { get; set; }
        public short Frqrcint { get; set; }
        public DateTime Strttime { get; set; }
        public DateTime Endtime { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Creatddt { get; set; }
        public string Crusrid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public byte Enabled { get; set; }
        public byte Keephist { get; set; }
        public short Nmbrtime { get; set; }
        public decimal Noteindx { get; set; }
        public string Schedtxt { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
