using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Mc00200
    {
        public int Actindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public byte Revalue { get; set; }
        public short Revluhow { get; set; }
        public short PostResultsTo { get; set; }
        public int DexRowId { get; set; }
    }
}
