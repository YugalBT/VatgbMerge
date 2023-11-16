using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00902
    {
        public int Financialindx { get; set; }
        public int Assetindex { get; set; }
        public int Bookindx { get; set; }
        public DateTime Transdatestamp { get; set; }
        public DateTime Transtimestamp { get; set; }
        public short Fiscalyradded { get; set; }
        public short Fayear { get; set; }
        public short Faperiod { get; set; }
        public DateTime Deprfromdate { get; set; }
        public DateTime Deprtodate { get; set; }
        public decimal Amount { get; set; }
        public string Transuserid { get; set; } = null!;
        public string Sourcdoc { get; set; } = null!;
        public short Transaccttype { get; set; }
        public byte Interfacegl { get; set; }
        public DateTime Glinttrxdate { get; set; }
        public DateTime Glintdatestamp { get; set; }
        public DateTime Glinttimestamp { get; set; }
        public int Glintacctindx { get; set; }
        public string Glintbtchnum { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
