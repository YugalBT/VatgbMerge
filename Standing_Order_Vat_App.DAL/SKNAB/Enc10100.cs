using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Enc10100
    {
        public string Ponumber { get; set; } = null!;
        public short Postatus { get; set; }
        public short Potype { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Reqdate { get; set; }
        public decimal Remsubto { get; set; }
        public decimal Subtotal { get; set; }
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public string Commntid { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public int Hold { get; set; }
        public short RevisionNumber { get; set; }
        public int Origin { get; set; }
        public int? DexRowId { get; set; }
    }
}
