using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn100201
    {
        public string Userid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public short CnCreditLevel { get; set; }
        public decimal CreditLevelFee { get; set; }
        public short Rmdtypal { get; set; }
        public string Docnumbr { get; set; } = null!;
        public byte UpdateCreditLevel { get; set; }
        public decimal Noteindx { get; set; }
        public short ActionType { get; set; }
        public decimal ActionAmount { get; set; }
        public decimal Ortrxamt { get; set; }
        public decimal Curtrxam { get; set; }
        public decimal Ororgtrx { get; set; }
        public decimal Orctrxam { get; set; }
        public DateTime Docdate { get; set; }
        public DateTime Duedate { get; set; }
        public DateTime CnLetterDate { get; set; }
        public short Agngbukt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public short CnNewCreditLevel { get; set; }
        public decimal CnNewCreditLevelFee { get; set; }
        public int DexRowId { get; set; }
    }
}
