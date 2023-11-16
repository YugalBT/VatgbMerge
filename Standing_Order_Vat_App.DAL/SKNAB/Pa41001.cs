using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41001
    {
        public string Pacostcatclasid { get; set; } = null!;
        public string Pacostcatclasnme { get; set; } = null!;
        public byte Padc { get; set; }
        public short Patu { get; set; }
        public byte PaivItemCheckbox { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public short Decplqty { get; set; }
        public decimal Paunitcost { get; set; }
        public string PapayCodeHourly { get; set; } = null!;
        public string PapayCodeSalary { get; set; } = null!;
        public short PatmprofitType { get; set; }
        public decimal PatmprofitAmount { get; set; }
        public decimal PatmprofitPercent { get; set; }
        public short PaprofitTypeCp { get; set; }
        public decimal PaprofitAmountCp { get; set; }
        public decimal PaprofitPercentCp { get; set; }
        public short PaffprofitType { get; set; }
        public decimal PaffprofitAmount { get; set; }
        public decimal PaffprofitPercent { get; set; }
        public short Decplcur { get; set; }
        public string Pacostaxscheduleid { get; set; } = null!;
        public short PapurchaseTaxOptions { get; set; }
        public string Pabilltaxscheduleid { get; set; } = null!;
        public short PasalesTaxOptions { get; set; }
        public short PaoverheadRateMethod { get; set; }
        public decimal PaovhdAmtPerUnit { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Panoteindex { get; set; }
        public int DexRowId { get; set; }
    }
}
