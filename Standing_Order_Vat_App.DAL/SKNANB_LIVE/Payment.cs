using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class Payment
    {
        public int IdPayment { get; set; }
        public int IdRegPayment { get; set; }
        public int IdEmployee { get; set; }
        public decimal MnyRegPay { get; set; }
        public decimal MnyGrossPay { get; set; }
        public decimal MnyOvrtime { get; set; }
        public decimal MnyTotAdj { get; set; }
        public decimal MnyNetPay { get; set; }
        public decimal MnyEmpeeSs { get; set; }
        public decimal MnyEmpeeSl { get; set; }
        public decimal MnyEmperSs { get; set; }
        public decimal MnyEmperSl { get; set; }
        public decimal MnyEmperSsInj { get; set; }
        public decimal MnyEmperSlSev { get; set; }
        public DateTime DtBegin { get; set; }
        public DateTime DtEnd { get; set; }
        public DateTime DtLastModified { get; set; }
        public DateTime? DtPaid { get; set; }
        public string? InPaid { get; set; }
        public string? InSentToSsb { get; set; }
        public decimal? MnyYtdGross { get; set; }
        public decimal? MnyYtdSs { get; set; }
        public decimal? MnyYtdSl { get; set; }
        public string? InOverride { get; set; }
        public int? GlSwExps { get; set; }
        public int? GlRegularPay { get; set; }
        public int? GlSsEmpee { get; set; }
        public int? GlSlEmpee { get; set; }
        public int? GlSsLiable { get; set; }
        public int? GlSsExps { get; set; }
        public int? GlSlLiable { get; set; }
        public int? GlSlExps { get; set; }
        public int? GlOvertime { get; set; }
        public string? InDelFlg { get; set; }
        public int? IdType { get; set; }
        public string? TxComment { get; set; }
        public int? IdHistory { get; set; }
    }
}
