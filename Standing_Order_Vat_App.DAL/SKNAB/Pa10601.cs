using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa10601
    {
        public string Papurordnum { get; set; } = null!;
        public int Ord { get; set; }
        public short Brkfld1 { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public DateTime Dateval { get; set; }
        public decimal Frtamnt { get; set; }
        public string Itmtshid { get; set; } = null!;
        public decimal Mscchamt { get; set; }
        public decimal Orfrtamt { get; set; }
        public decimal Omiscamt { get; set; }
        public decimal Ortdisam { get; set; }
        public decimal PabaseQty { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public byte Pacbaddfrmfly { get; set; }
        public string Pachgordno { get; set; } = null!;
        public int PacogsIdx { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public byte PaivItemCheckbox { get; set; }
        public int PalineItemSeq { get; set; }
        public decimal Paorgbsunitcst { get; set; }
        public string Paprojname { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public short Patu { get; set; }
        public int Pacgbwipidx { get; set; }
        public decimal PostedSubtotal { get; set; }
        public string Pricelvl { get; set; } = null!;
        public decimal Trdisamt { get; set; }
        public string Uomschdl { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
