using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05256
    {
        public short ReturnRecordType { get; set; }
        public string Retdocid { get; set; } = null!;
        public decimal Lnseqnbr { get; set; }
        public short Qtytype { get; set; }
        public decimal Serltqty { get; set; }
        public int Sltsqnum { get; set; }
        public string ReplaceItemNumber { get; set; } = null!;
        public string ReplaceSerialNumber { get; set; } = null!;
        public int ReplaceEquipmentId { get; set; }
        public string Bin { get; set; } = null!;
        public decimal ReplaceCost { get; set; }
        public int DexRowId { get; set; }
    }
}
