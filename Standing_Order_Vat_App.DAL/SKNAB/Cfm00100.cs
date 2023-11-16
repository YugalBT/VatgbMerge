using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cfm00100
    {
        public string EbsForecastId { get; set; } = null!;
        public string ForecastDescription { get; set; } = null!;
        public byte DefaultForecast { get; set; }
        public DateTime LastCalendarDate { get; set; }
        public DateTime LastCalcTime { get; set; }
        public byte BankReconcilation { get; set; }
        public decimal OpeningBalanceAmount { get; set; }
        public int Actindx { get; set; }
        public byte RmOpen { get; set; }
        public byte RmWork { get; set; }
        public short RmDateType { get; set; }
        public byte Sop { get; set; }
        public byte SopIncludeQuotes { get; set; }
        public byte PmOpen { get; set; }
        public byte PmWork { get; set; }
        public byte Pop { get; set; }
        public short PopBasedOn { get; set; }
        public byte CashManagementTransact { get; set; }
        public short Week { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
