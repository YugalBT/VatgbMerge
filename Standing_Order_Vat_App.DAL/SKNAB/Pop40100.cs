using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pop40100
    {
        public short Index1 { get; set; }
        public string PoCode { get; set; } = null!;
        public string Ponumber { get; set; } = null!;
        public short Poformat { get; set; }
        public string Poprctnm { get; set; } = null!;
        public string ReceiptCode { get; set; } = null!;
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public byte Pohist { get; set; }
        public byte Rcpthist { get; set; }
        public byte Disthist { get; set; }
        public short Dsplyitm { get; set; }
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public short NumberOfLines { get; set; }
        public byte Popalwop1 { get; set; }
        public byte Popalwop2 { get; set; }
        public byte Popalwop3 { get; set; }
        public byte Popalwop4 { get; set; }
        public string Poppswrd1 { get; set; } = null!;
        public string Poppswrd2 { get; set; } = null!;
        public string Poppswrd3 { get; set; } = null!;
        public string Poppswrd4 { get; set; } = null!;
        public short Defaultsitemethod { get; set; }
        public byte Allowholdedit { get; set; }
        public byte Autohold { get; set; }
        public byte SearchPoqtysFromSo { get; set; }
        public byte TransferLineComments { get; set; }
        public short PurchaseNonIvTaxable { get; set; }
        public short PurchaseFreightTaxable { get; set; }
        public short PurchaseMiscTaxable { get; set; }
        public string Nonivsch { get; set; } = null!;
        public string Frtschid { get; set; } = null!;
        public string Mscschid { get; set; } = null!;
        public short Useadvtx { get; set; }
        public string Taxschid { get; set; } = null!;
        public string UserDefinedPrompt01 { get; set; } = null!;
        public string UserDefinedPrompt02 { get; set; } = null!;
        public string UserDefinedPrompt03 { get; set; } = null!;
        public string UserDefinedPrompt04 { get; set; } = null!;
        public string UserDefinedPrompt05 { get; set; } = null!;
        public string UserDefinedPrompt06 { get; set; } = null!;
        public string UserDefinedPrompt07 { get; set; } = null!;
        public string UserDefinedPrompt08 { get; set; } = null!;
        public string UserDefinedPrompt09 { get; set; } = null!;
        public string UserDefinedPrompt10 { get; set; } = null!;
        public string UserDefinedPrompt11 { get; set; } = null!;
        public string UserDefinedPrompt12 { get; set; } = null!;
        public string UserDefinedPrompt13 { get; set; } = null!;
        public string UserDefinedPrompt14 { get; set; } = null!;
        public string UserDefinedPrompt15 { get; set; } = null!;
        public string UserDefinedPrompt16 { get; set; } = null!;
        public string UserDefinedPrompt17 { get; set; } = null!;
        public string UserDefinedPrompt18 { get; set; } = null!;
        public string UserDefinedPrompt19 { get; set; } = null!;
        public string UserDefinedPrompt20 { get; set; } = null!;
        public string UserDefinedPrompt21 { get; set; } = null!;
        public string UserDefinedPrompt22 { get; set; } = null!;
        public string UserDefinedPrompt23 { get; set; } = null!;
        public string UserDefinedPrompt24 { get; set; } = null!;
        public string UserDefinedPrompt25 { get; set; } = null!;
        public string UserDefinedPrompt26 { get; set; } = null!;
        public string UserDefinedPrompt27 { get; set; } = null!;
        public string UserDefinedPrompt28 { get; set; } = null!;
        public string UserDefinedPrompt29 { get; set; } = null!;
        public string UserDefinedPrompt30 { get; set; } = null!;
        public string UserDefinedPrompt31 { get; set; } = null!;
        public string UserDefinedPrompt32 { get; set; } = null!;
        public string UserDefinedPrompt33 { get; set; } = null!;
        public string UserDefinedPrompt34 { get; set; } = null!;
        public string UserDefinedPrompt35 { get; set; } = null!;
        public decimal FreightTaxSchedNoteIdx { get; set; }
        public decimal MiscTaxSchedNoteIdx { get; set; }
        public decimal NonIvtaxSchedNoteIdx { get; set; }
        public decimal SingleTaxSchedNoteIdx { get; set; }
        public short ReplenishmentLevel { get; set; }
        public short PoporderMethod { get; set; }
        public string MasterLocationCode { get; set; } = null!;
        public short PopvendorSelection { get; set; }
        public short PoppricingSelection { get; set; }
        public byte IncludeAllocations { get; set; }
        public byte IncludeBackorders { get; set; }
        public byte IncludeRequisitions { get; set; }
        public byte Retorigtax { get; set; }
        public byte Onepoperaddr { get; set; }
        public byte Calcreldt { get; set; }
        public short DefaultDocumentDate { get; set; }
        public int DexRowId { get; set; }
    }
}
