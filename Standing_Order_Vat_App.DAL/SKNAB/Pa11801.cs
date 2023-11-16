using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa11801
    {
        public short Patu { get; set; }
        public string Padocnumber20 { get; set; } = null!;
        public string Parefno { get; set; } = null!;
        public DateTime Padt { get; set; }
        public string Papurordnum { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public string Pacostcatid { get; set; } = null!;
        public string PacontMgrId { get; set; } = null!;
        public string Paitemnumber { get; set; } = null!;
        public string Employid { get; set; } = null!;
        public string Pacostowner { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Paprojmngrid { get; set; } = null!;
        public short PaprojectType { get; set; }
        public string Slprsnid { get; set; } = null!;
        public DateTime Patb { get; set; }
        public DateTime Pate { get; set; }
        public short Paconvtmints { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal PaqtyQ { get; set; }
        public decimal PabaseQty { get; set; }
        public string PaunitOfMeasure { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public decimal Paunitcost { get; set; }
        public decimal Oruntcst { get; set; }
        public decimal PabaseUnitCost { get; set; }
        public decimal Paorgbsunitcst { get; set; }
        public decimal PaoverheadAmount { get; set; }
        public decimal Paorigovhdamt { get; set; }
        public decimal PaoverheaPercentage { get; set; }
        public decimal Patotaloverh { get; set; }
        public decimal Paorigtotovrhd { get; set; }
        public decimal Patotcst { get; set; }
        public decimal Paorigtotcost { get; set; }
        public short Pabllngtype { get; set; }
        public decimal Bktpuram { get; set; }
        public decimal Pabilrate { get; set; }
        public decimal Paorigbillrate { get; set; }
        public decimal PaBaseBillingRate { get; set; }
        public decimal Paorigbsbillrte { get; set; }
        public decimal Pamarkpercent { get; set; }
        public decimal Paacrev { get; set; }
        public decimal Paoriaccrrev { get; set; }
        public decimal PastdQty { get; set; }
        public decimal PancQty { get; set; }
        public decimal PasplitNc { get; set; }
        public decimal PanbQty { get; set; }
        public short PapurchaseTaxOptions { get; set; }
        public string Itmtshid { get; set; } = null!;
        public decimal Trdisamt { get; set; }
        public decimal Frtamnt { get; set; }
        public decimal Mscchamt { get; set; }
        public decimal Taxamnt { get; set; }
        public int Lnitmseq { get; set; }
        public int PareferenceLineSeqN { get; set; }
        public DateTime Paexptdate { get; set; }
        public short PabillingStatusN { get; set; }
        public string Paud1 { get; set; } = null!;
        public string Paud2 { get; set; } = null!;
        public string Paprjclsid { get; set; } = null!;
        public string Custclas { get; set; } = null!;
        public string Pacontclassid { get; set; } = null!;
        public string Pacostcatclasid { get; set; } = null!;
        public string PapayCode { get; set; } = null!;
        public string Statecd { get; set; } = null!;
        public string Loclcode { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public short PasalaryPostingType { get; set; }
        public string PajobTitle { get; set; } = null!;
        public string Padepartment { get; set; } = null!;
        public decimal PabilledQtyN { get; set; }
        public decimal PabilledTax { get; set; }
        public decimal PabilledMisc { get; set; }
        public short PaprofitType { get; set; }
        public decimal PaprofitAmount { get; set; }
        public decimal Paorigprofamt { get; set; }
        public decimal PaprofitPercent { get; set; }
        public decimal PatotalProfit { get; set; }
        public decimal Paorigtotprof { get; set; }
        public decimal PaapprovedQuantity { get; set; }
        public decimal Paapprovbillrate { get; set; }
        public decimal Paapprovmkuppct { get; set; }
        public decimal PaapprovedBillingAmou { get; set; }
        public decimal PaBilledProfitAmount { get; set; }
        public decimal PabilledProfitPercentage { get; set; }
        public decimal PabilledAmount { get; set; }
        public decimal PabilledFreight { get; set; }
        public decimal PabilledDiscount { get; set; }
        public decimal PawriteUpDownAmount { get; set; }
        public int PawriteUpDownPercenta { get; set; }
        public string PaapproverId { get; set; } = null!;
        public short PaapproverType { get; set; }
        public byte PapartialBill { get; set; }
        public int Pacgbwipidx { get; set; }
        public int PaunbilledArIdx { get; set; }
        public int PaunbilledProjRevIdx { get; set; }
        public int PaoverheadIdx { get; set; }
        public int PacontraAccountIdx { get; set; }
        public int PacogsIdx { get; set; }
        public short PapaymentMethod { get; set; }
        public short PaexpenseType { get; set; }
        public string Locncode { get; set; } = null!;
        public string Pricelvl { get; set; } = null!;
        public int Ivivindx { get; set; }
        public string Ivivofac1 { get; set; } = null!;
        public string Ivivofac2 { get; set; } = null!;
        public string Ivivofac3 { get; set; } = null!;
        public string Ivivofac4 { get; set; } = null!;
        public string Ivivofac5 { get; set; } = null!;
        public string Ivivofac6 { get; set; } = null!;
        public string Ivivofac7 { get; set; } = null!;
        public string Ivivofac8 { get; set; } = null!;
        public string Ivivofac9 { get; set; } = null!;
        public string Ivivofac10 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
