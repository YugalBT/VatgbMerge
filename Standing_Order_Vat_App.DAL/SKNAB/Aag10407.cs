using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag10407
    {
        public string Userid { get; set; } = null!;
        public string Trxbtchsrc { get; set; } = null!;
        public byte DestinationStructure1 { get; set; }
        public byte DestinationStructure2 { get; set; }
        public byte DestinationStructure3 { get; set; }
        public byte DestinationStructure4 { get; set; }
        public string DestinationStructure5 { get; set; } = null!;
        public string DestinationStructure6 { get; set; } = null!;
        public short DestinationStructure7 { get; set; }
        public byte DestinationStructure8 { get; set; }
        public string DestinationStructure9 { get; set; } = null!;
        public short Series { get; set; }
        public string AaReportName { get; set; } = null!;
        public string Editlststr { get; set; } = null!;
        public string Trnltrxsrc { get; set; } = null!;
        public string Prntask { get; set; } = null!;
        public byte AaIsErrorList { get; set; }
        public int DexRowId { get; set; }
    }
}
