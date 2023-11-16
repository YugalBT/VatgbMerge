using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41101
    {
        public string Pacontclassid { get; set; } = null!;
        public string Pacontclassname { get; set; } = null!;
        public byte Padc { get; set; }
        public short Pacommselrb { get; set; }
        public short Comprcnt { get; set; }
        public short Comappto { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Pabillnoteidxts { get; set; }
        public decimal Paelbillniteidx { get; set; }
        public decimal PabillnoteidxMl { get; set; }
        public decimal Pabillnoteidxvi { get; set; }
        public decimal Pabillnoteidxee { get; set; }
        public decimal Pabillnoteidxinv { get; set; }
        public decimal Pabillnoteidxfee { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
