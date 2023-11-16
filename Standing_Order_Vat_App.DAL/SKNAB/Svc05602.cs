using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05602
    {
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public short Qtytype { get; set; }
        public decimal Serltqty { get; set; }
        public int Sltsqnum { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public string SvcSerialId { get; set; } = null!;
        public int Equipid { get; set; }
        public string ReturnItemNumber { get; set; } = null!;
        public string ReturnSerialNumber { get; set; } = null!;
        public string SvcReturnSerialId { get; set; } = null!;
        public int ReturnEquipmentId { get; set; }
        public string Bin { get; set; } = null!;
        public string Tobin { get; set; } = null!;
        public decimal Retcost { get; set; }
        public byte SvcOriginalSerial { get; set; }
        public DateTime Daterecd { get; set; }
        public decimal Dtseqnum { get; set; }
        public string Trxsorce { get; set; } = null!;
        public byte Shipped { get; set; }
        public byte Marked { get; set; }
        public byte Posted { get; set; }
        public int DexRowId { get; set; }
    }
}
