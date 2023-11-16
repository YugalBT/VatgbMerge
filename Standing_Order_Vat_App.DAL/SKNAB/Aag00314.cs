using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Aag00314
    {
        public int AaMlqueryId { get; set; }
        public short AaColumn { get; set; }
        public byte AaUseTree { get; set; }
        public byte AaUseCodes { get; set; }
        public int AaTreeId { get; set; }
        public int AaTreeLevel { get; set; }
        public byte AaInclEmptyCodes { get; set; }
        public short AaSelectOption { get; set; }
        public string AaFromStr { get; set; } = null!;
        public string AaToStr { get; set; } = null!;
        public decimal AaFromNum { get; set; }
        public decimal AaToNum { get; set; }
        public byte AaFromBool { get; set; }
        public byte AaToBool { get; set; }
        public DateTime AaFromDate { get; set; }
        public DateTime AaToDate { get; set; }
        public string FromAccountNumber1 { get; set; } = null!;
        public string FromAccountNumber2 { get; set; } = null!;
        public string FromAccountNumber3 { get; set; } = null!;
        public string FromAccountNumber4 { get; set; } = null!;
        public string FromAccountNumber5 { get; set; } = null!;
        public string FromAccountNumber6 { get; set; } = null!;
        public string FromAccountNumber7 { get; set; } = null!;
        public string FromAccountNumber8 { get; set; } = null!;
        public string FromAccountNumber9 { get; set; } = null!;
        public string FromAccountNumber10 { get; set; } = null!;
        public string ToAccountNumber1 { get; set; } = null!;
        public string ToAccountNumber2 { get; set; } = null!;
        public string ToAccountNumber3 { get; set; } = null!;
        public string ToAccountNumber4 { get; set; } = null!;
        public string ToAccountNumber5 { get; set; } = null!;
        public string ToAccountNumber6 { get; set; } = null!;
        public string ToAccountNumber7 { get; set; } = null!;
        public string ToAccountNumber8 { get; set; } = null!;
        public string ToAccountNumber9 { get; set; } = null!;
        public string ToAccountNumber10 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
