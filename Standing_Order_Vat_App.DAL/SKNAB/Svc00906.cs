using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00906
    {
        public string Warrcde { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short Wrntydys { get; set; }
        public string Srvtype { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public decimal Partpct { get; set; }
        public decimal Labpct { get; set; }
        public decimal AddlPct { get; set; }
        public string VendorAuthorization { get; set; } = null!;
        public string RtvType { get; set; } = null!;
        public short Etadays { get; set; }
        public string VendorLocationCode { get; set; } = null!;
        public byte CreatePo { get; set; }
        public int Meter1 { get; set; }
        public int Meter2 { get; set; }
        public int Meter3 { get; set; }
        public string Rettype { get; set; } = null!;
        public decimal VendorPartsAmount { get; set; }
        public string VendorPartsDollarOrP { get; set; } = null!;
        public decimal VendorLaborAmount { get; set; }
        public string VendorLaborDollarOrP { get; set; } = null!;
        public decimal VendorAddlAmount { get; set; }
        public string VendorAddlDollarOrPc { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
