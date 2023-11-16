using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa42601
    {
        public short PabillFormatKey { get; set; }
        public string PabillDesc { get; set; } = null!;
        public string Pabillformname { get; set; } = null!;
        public short PaContractStickPin { get; set; }
        public byte Paprntcontheading1 { get; set; }
        public byte Paprntcontrxbillnotes1 { get; set; }
        public short PaContractCollating { get; set; }
        public short PaProjectStickPin { get; set; }
        public byte Paprntprojheadings1 { get; set; }
        public byte Paprntprojtrxbillnotes1 { get; set; }
        public short PaProjectCollating { get; set; }
        public short PaFeesStickPin { get; set; }
        public short PafeesDisplayOptions { get; set; }
        public byte PaprintBillNotesFee { get; set; }
        public string PalongFeeNameProject { get; set; } = null!;
        public string PalongFeeNameRetainer { get; set; } = null!;
        public string PalongFeeNameRetentions { get; set; } = null!;
        public string PalongFeeNameService { get; set; } = null!;
        public short PaTrxsStickPin { get; set; }
        public short Paprntsummts { get; set; }
        public short Paprntsummel { get; set; }
        public short Paprntsummml { get; set; }
        public short Paprntsummiv { get; set; }
        public short Paprntsummvi { get; set; }
        public short Paprntsummee { get; set; }
        public short PaprintSummaryCpfpts { get; set; }
        public short PaprintSummaryCpfpel { get; set; }
        public short PaprintSummaryCpfpml { get; set; }
        public short PaprintSummaryCpfpiv { get; set; }
        public short PaprintSummaryCpfpvi { get; set; }
        public short PaprintSummaryCpfpee { get; set; }
        public byte Paprntbillnotests1 { get; set; }
        public byte PaprntbillnotesEl { get; set; }
        public byte PaprntbillnotesMl { get; set; }
        public byte PaprntbillnotesIv { get; set; }
        public byte Paprntbillnotesvi1 { get; set; }
        public byte Paprntbillnotesee1 { get; set; }
        public short Paprntsortts { get; set; }
        public short Paprntsortel { get; set; }
        public short Paprntsortml { get; set; }
        public short Paprntsortiv { get; set; }
        public short Paprntsortvi { get; set; }
        public short Paprntsortee { get; set; }
        public string PalongTrxNameTs { get; set; } = null!;
        public string PalongTrxNameEl { get; set; } = null!;
        public string PalongTrxNameMl { get; set; } = null!;
        public string PalongTrxNameIv { get; set; } = null!;
        public string PalongTrxNameVi { get; set; } = null!;
        public string PalongTrxNameEe { get; set; } = null!;
        public short PaifdataPrinted { get; set; }
        public int DexRowId { get; set; }
    }
}
