using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa02000
    {
        public string Pabillcycleid { get; set; } = null!;
        public string Pabillcycledesc { get; set; } = null!;
        public short PabillingFrequency { get; set; }
        public short PabillingFreqDetail { get; set; }
        public short PaDay1 { get; set; }
        public short PaMonthNumber1 { get; set; }
        public short PaMonthNumber2 { get; set; }
        public short PaDayNumber1 { get; set; }
        public short PaDayNumber2 { get; set; }
        public short PaDay2 { get; set; }
        public short PadaysInterval { get; set; }
        public short Paddlday { get; set; }
        public short PapriorDaysBeforeBi { get; set; }
        public byte PainclSrvFees { get; set; }
        public byte PaIncludeProjectFee { get; set; }
        public byte PaIncludeRetainerFee { get; set; }
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public byte Patotcbfee { get; set; }
        public short Paefbillfmt { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
