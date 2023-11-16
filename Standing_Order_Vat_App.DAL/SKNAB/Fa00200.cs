using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa00200
    {
        public int Assetindex { get; set; }
        public int Bookindx { get; set; }
        public DateTime Plinservdate { get; set; }
        public DateTime Deletedate { get; set; }
        public DateTime Deprbegdate { get; set; }
        public string Fullydeprflag { get; set; } = null!;
        public DateTime Fullydeprdate { get; set; }
        public short Originallifeyears { get; set; }
        public short Originallifedays { get; set; }
        public short Remaininglifeyears { get; set; }
        public short Remaininglifedays { get; set; }
        public DateTime Deprtodate { get; set; }
        public DateTime Lastrecalcdate { get; set; }
        public short Lastrecalcdatefisyr { get; set; }
        public decimal Beginyearcost { get; set; }
        public decimal Baginsalvage { get; set; }
        public decimal Beginreserve { get; set; }
        public decimal Costbasis { get; set; }
        public decimal Salvagevalue { get; set; }
        public short Depreciationmethod { get; set; }
        public short Averagingconv { get; set; }
        public short Switchover { get; set; }
        public short Switchfm1method { get; set; }
        public decimal Switchfm1amount { get; set; }
        public DateTime Switchfm1date { get; set; }
        public decimal Dlydeprrate { get; set; }
        public decimal Perdeprrate { get; set; }
        public decimal Yrlydeprrate { get; set; }
        public decimal Savedlydeprrate { get; set; }
        public decimal Saveperdeprrate { get; set; }
        public decimal Saveyrlydeprrate { get; set; }
        public short Amortizationcode { get; set; }
        public decimal Amortizationamount { get; set; }
        public decimal Currundepramt { get; set; }
        public decimal Prevrundepramt { get; set; }
        public decimal Ytddepramt { get; set; }
        public decimal Ltddepramt { get; set; }
        public decimal Netbookvalue { get; set; }
        public short Luxautoind { get; set; }
        public DateTime Proratedretdate { get; set; }
        public DateTime Deprtodatebfret { get; set; }
        public decimal Recgainloss { get; set; }
        public decimal Nonrecgainloss { get; set; }
        public decimal Stlinedepratret { get; set; }
        public decimal Costbfretordel { get; set; }
        public short InitialAllowancePerc { get; set; }
        public decimal InitialAllowanceAmount { get; set; }
        public short Specdeprallow { get; set; }
        public short Specdeprallowpct { get; set; }
        public decimal Specdeprallowamt { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Dateadded { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public byte Luxvantruck { get; set; }
        public byte Luxelauto { get; set; }
        public int DexRowId { get; set; }
    }
}
