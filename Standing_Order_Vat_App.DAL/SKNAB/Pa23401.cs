using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa23401
    {
        public string Pacontnumber { get; set; } = null!;
        public string Pachgordno { get; set; } = null!;
        public short Pacotrkchgby { get; set; }
        public int Lnitmseq { get; set; }
        public string Paprojnumber { get; set; } = null!;
        public short Patu { get; set; }
        public string Pacostcatid { get; set; } = null!;
        public int PalineItemSeq { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public DateTime Paprevbegindt { get; set; }
        public DateTime Pabegindate { get; set; }
        public DateTime Paprevenddt { get; set; }
        public DateTime PaenDate { get; set; }
        public string Paprevpycdesly { get; set; } = null!;
        public string PapayCodeSalary { get; set; } = null!;
        public string Paprevpycodehourly { get; set; } = null!;
        public string PapayCodeHourly { get; set; } = null!;
        public short PaprofitType { get; set; }
        public short Pabllngtype { get; set; }
        public short Paprevpurchtxopt { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public string Paprevcostxsched { get; set; } = null!;
        public string Papurchtaxsched { get; set; } = null!;
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Paprevsalestxopt { get; set; }
        public short PasalesTaxOptions { get; set; }
        public string Paprevbilltxsched { get; set; } = null!;
        public string Pabilltaxscheduleid { get; set; } = null!;
        public decimal PavarianceQty { get; set; }
        public decimal PaqtyQ { get; set; }
        public decimal PavarianceCosts { get; set; }
        public decimal Paunitcost { get; set; }
        public decimal Pavartotcost { get; set; }
        public decimal Pavaroverhdamt { get; set; }
        public decimal Patotaloverh { get; set; }
        public decimal Pavaroverhdprcnt { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public decimal Pavarovrhdunit { get; set; }
        public decimal PaovhdAmtPerUnit { get; set; }
        public decimal Patotcst { get; set; }
        public decimal Pavarmuprcnt { get; set; }
        public decimal PaprofitPercent { get; set; }
        public decimal Pavarprofamt { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal Pavartotlprof { get; set; }
        public decimal PatotalProfit { get; set; }
        public decimal Pavartotbillings { get; set; }
        public decimal Patotbillings { get; set; }
        public decimal Paorigbudgtamt { get; set; }
        public decimal Parogprojamt { get; set; }
        public decimal Pavarprojamt { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal Paprevprojamt { get; set; }
        public decimal Paprevbaseqty { get; set; }
        public decimal PabaseQty { get; set; }
        public decimal Paprevbseuntcst { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Paprevbsoverhdcst { get; set; }
        public decimal PabaseOvhdCost { get; set; }
        public decimal Paprevbsprofamt { get; set; }
        public decimal PabaseProfitAmount { get; set; }
        public decimal Papropquoteamt { get; set; }
        public decimal Pafinquoteamt { get; set; }
        public string Paquoteprepby { get; set; } = null!;
        public string Paquoteapprvby { get; set; } = null!;
        public decimal Parevbudgtamt { get; set; }
        public decimal Parevprojamt { get; set; }
        public short Pasequencenumber { get; set; }
        public DateTime Apprvldt { get; set; }
        public byte PacloseCb { get; set; }
        public decimal PapostedQty { get; set; }
        public decimal PapostedTotalCostN { get; set; }
        public decimal PapostedOverhead { get; set; }
        public decimal PapostedProfitN { get; set; }
        public decimal PapostedTaxAmount { get; set; }
        public decimal PapostedAccrRevN { get; set; }
        public decimal PapostRecogRevN { get; set; }
        public decimal Paposbieeamount { get; set; }
        public decimal Paposeiebamount { get; set; }
        public decimal Papostbillamt { get; set; }
        public decimal PaActualReceiptsAmoun { get; set; }
        public decimal PapostedBillingsN { get; set; }
        public decimal PapostedDiscDolAmtN { get; set; }
        public decimal PapostedSalesTaxAmou { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
        public decimal PapostedTaxPaidN { get; set; }
        public decimal Papostretamt { get; set; }
        public decimal PaactualWotaxAmt { get; set; }
        public decimal PaactualTermsTakenTax { get; set; }
        public int DexRowId { get; set; }
    }
}
