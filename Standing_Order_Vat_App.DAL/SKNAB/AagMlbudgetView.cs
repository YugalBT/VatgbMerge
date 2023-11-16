using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class AagMlbudgetView
    {
        public int Reptype { get; set; }
        public int? AaBudgetId { get; set; }
        public string? AaBudget { get; set; }
        public string? AaBudgetDescr { get; set; }
        public short? Year1 { get; set; }
        public int? AaBudgetTreeId { get; set; }
        public string? AaBudgetTree { get; set; }
        public string? AaBudgetTreeDescr { get; set; }
        public int? AaTrxDimId { get; set; }
        public string? AaTrxDim { get; set; }
        public string? AaTrxDimDescr { get; set; }
        public int? AaOrder { get; set; }
        public int? AaTrxDimCodeId { get; set; }
        public string? AaTrxDimCode { get; set; }
        public string? AaTrxDimCodeDescr { get; set; }
        public int? AaCodeSequence { get; set; }
        public string? AaLvlCodeString { get; set; }
        public short AaFiscalPeriod { get; set; }
        public int AaActualPriliminary { get; set; }
        public decimal Balance { get; set; }
        public int Actindx { get; set; }
        public string Actnumst { get; set; } = null!;
        public string Actdescr { get; set; } = null!;
        public int Accttype { get; set; }
        public int Pstngtyp { get; set; }
    }
}
