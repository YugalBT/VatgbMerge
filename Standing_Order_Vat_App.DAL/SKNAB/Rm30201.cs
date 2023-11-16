using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rm30201
    {
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime Glpostdt { get; set; }
        public byte Posted { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public string Aptodcnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public DateTime Aptodcdt { get; set; }
        public DateTime ApplyToGlpostDate { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Apptoamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Wrofamnt { get; set; }
        public decimal Oraptoam { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal Aptoexrate { get; set; }
        public decimal Aptodenrate { get; set; }
        public short Aptortclcmeth { get; set; }
        public short Aptomctrxstt { get; set; }
        public string Apfrdcnm { get; set; } = null!;
        public short Apfrdcty { get; set; }
        public DateTime Apfrdcdt { get; set; }
        public DateTime ApplyFromGlpostDate { get; set; }
        public string Fromcurr { get; set; } = null!;
        public decimal Apfrmaplyamt { get; set; }
        public decimal Apfrmdisctaken { get; set; }
        public decimal Apfrmdiscavail { get; set; }
        public decimal Apfrmwrofamt { get; set; }
        public decimal ActualApplyToAmount { get; set; }
        public decimal ActualDiscTakenAmount { get; set; }
        public decimal ActualDiscAvailTaken { get; set; }
        public decimal ActualWriteOffAmount { get; set; }
        public decimal Apfrmexrate { get; set; }
        public decimal Apfrmdenrate { get; set; }
        public short Apfrmrtclcmeth { get; set; }
        public short Apfrmmctrxstt { get; set; }
        public decimal Apyfrmrndamt { get; set; }
        public decimal Apytorndamt { get; set; }
        public decimal Apytornddisc { get; set; }
        public decimal Oapyfrmrndamt { get; set; }
        public decimal Oapytorndamt { get; set; }
        public decimal Oapytornddisc { get; set; }
        public decimal Gstdsamt { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Rlganlos { get; set; }
        public decimal SettledGainCreditCurrT { get; set; }
        public decimal SettledLossCreditCurrT { get; set; }
        public decimal SettledGainDebitCurrTr { get; set; }
        public decimal SettledLossDebitCurrTr { get; set; }
        public decimal SettledGainDebitDiscAv { get; set; }
        public decimal SettledLossDebitDiscAv { get; set; }
        public short RevaluationStatus { get; set; }
        public int DexRowId { get; set; }
    }
}
