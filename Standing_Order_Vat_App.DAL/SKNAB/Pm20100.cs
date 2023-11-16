using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm20100
    {
        public string Keysourc { get; set; } = null!;
        public DateTime Docdate { get; set; }
        public DateTime Time1 { get; set; }
        public string Vendorid { get; set; } = null!;
        public byte Posted { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Userid { get; set; } = null!;
        public string Aptvchnm { get; set; } = null!;
        public short Aptodcty { get; set; }
        public DateTime Aptodcdt { get; set; }
        public string Aptodcnm { get; set; } = null!;
        public decimal Appldamt { get; set; }
        public decimal Distknam { get; set; }
        public decimal Disavtkn { get; set; }
        public decimal Wrofamnt { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public decimal Orappamt { get; set; }
        public decimal Ordistkn { get; set; }
        public decimal Ordatkn { get; set; }
        public decimal Orwrofam { get; set; }
        public decimal ApplyToDocumentAmount { get; set; }
        public decimal ApplyToOrigDocAmount { get; set; }
        public DateTime ApplyToDiscountDate { get; set; }
        public DateTime ApplyToDueDate { get; set; }
        public string ApplyToDescription { get; set; } = null!;
        public short ApplyToIsMcTrx { get; set; }
        public DateTime ApplyToGlpostDate { get; set; }
        public decimal Aptoexrate { get; set; }
        public decimal Aptodenrate { get; set; }
        public short Aptortclcmeth { get; set; }
        public short Aptomctrxstt { get; set; }
        public short Ismctrx { get; set; }
        public string Vchrnmbr { get; set; } = null!;
        public short Doctype { get; set; }
        public string Apfrdcnm { get; set; } = null!;
        public string Fromcurr { get; set; } = null!;
        public decimal ApplyFromDocumentAmou { get; set; }
        public decimal ApplyFromOrigDocAmou { get; set; }
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
        public string ApplyFromDescription { get; set; } = null!;
        public short ApplyFromIsMcTrx { get; set; }
        public decimal Ppsamded { get; set; }
        public decimal Gstdsamt { get; set; }
        public string Taxdtlid { get; set; } = null!;
        public decimal Updtknam { get; set; }
        public decimal Upgstdam { get; set; }
        public decimal Unpppsad { get; set; }
        public decimal Upwrofam { get; set; }
        public byte[] Pmdstmsg { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public string Mdfusrid { get; set; } = null!;
        public DateTime Posteddt { get; set; }
        public string Ptdusrid { get; set; } = null!;
        public decimal Ten99amnt { get; set; }
        public decimal Rlganlos { get; set; }
        public decimal Apyfrmrndamt { get; set; }
        public decimal Apytorndamt { get; set; }
        public decimal Apytornddisc { get; set; }
        public decimal Xchgrate { get; set; }
        public short Decplcur { get; set; }
        public short Ratecalc { get; set; }
        public string PaymentToPrintOnStub { get; set; } = null!;
        public decimal Oapyfrmrndamt { get; set; }
        public decimal Oapytorndamt { get; set; }
        public decimal Oapytornddisc { get; set; }
        public decimal SettledGainCreditCurrT { get; set; }
        public decimal SettledLossCreditCurrT { get; set; }
        public decimal SettledGainDebitCurrTr { get; set; }
        public decimal SettledLossDebitCurrTr { get; set; }
        public decimal SettledGainDebitDiscAv { get; set; }
        public decimal SettledLossDebitDiscAv { get; set; }
        public string Vadcdtro { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
