using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10100
    {
        public short Rptngyr { get; set; }
        public string Epridnbr { get; set; } = null!;
        public byte Yendcrtd { get; set; }
        public string Estidnbr { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public string Cmpnynam { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public byte Inacw2rn { get; set; }
        public short Yeprw2sk { get; set; }
        public short Ypmqgew2 { get; set; }
        public short Yp1099rs { get; set; }
        public int Ficasstr { get; set; }
        public decimal Ficasswl { get; set; }
        public int Ticamtrt { get; set; }
        public decimal Ficamwlm { get; set; }
        public decimal Eicmxwhg { get; set; }
        public short EstablishmentType { get; set; }
        public string EstablishmentNumber { get; set; } = null!;
        public decimal ChargedTips { get; set; }
        public decimal ChargedReceipts { get; set; }
        public decimal IndirectTips { get; set; }
        public decimal DirectTips { get; set; }
        public decimal Receipts { get; set; }
        public short DirectlyTipped { get; set; }
        public short ReturnType { get; set; }
        public decimal ReportedTips { get; set; }
        public decimal Aloctips { get; set; }
        public int DexRowId { get; set; }
    }
}
