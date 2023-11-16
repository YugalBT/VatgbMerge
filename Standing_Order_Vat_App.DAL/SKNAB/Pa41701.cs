using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41701
    {
        public short Pasetupkey { get; set; }
        public string Pacontractdefined1 { get; set; } = null!;
        public string Pacontractdefined2 { get; set; } = null!;
        public string Pacostcatdefined1 { get; set; } = null!;
        public string Pacostcatdefined2 { get; set; } = null!;
        public string Pacustomerdefined1 { get; set; } = null!;
        public string Pacustomerdefined2 { get; set; } = null!;
        public string Paemployeedefined1 { get; set; } = null!;
        public string Paemployeedefined2 { get; set; } = null!;
        public string Pavendordefinedprompt1 { get; set; } = null!;
        public string Pavendordefinedprompt2 { get; set; } = null!;
        public string Pamiscdefined1 { get; set; } = null!;
        public string Pamiscldefined2 { get; set; } = null!;
        public string Paprojectdefined1 { get; set; } = null!;
        public string Paprojectdefined2 { get; set; } = null!;
        public string Paequiptdefined1 { get; set; } = null!;
        public string Paequiptdefined2 { get; set; } = null!;
        public string PauserDefinedPrompt1Fee { get; set; } = null!;
        public string PauserDefinedPrompt2Fee { get; set; } = null!;
        public string Pacontractstatus1 { get; set; } = null!;
        public string Pacontractstatus2 { get; set; } = null!;
        public string Pacontractstatus3 { get; set; } = null!;
        public string Pacontractstatus4 { get; set; } = null!;
        public string Pacontractstatus5 { get; set; } = null!;
        public string Pacontractstatus6 { get; set; } = null!;
        public string Pacontractstatus7 { get; set; } = null!;
        public string Pacontractstatus8 { get; set; } = null!;
        public string Pacontractstatus9 { get; set; } = null!;
        public string Pacontractstatus10 { get; set; } = null!;
        public byte Pacontstatcb1 { get; set; }
        public byte Pacontstatcb2 { get; set; }
        public byte Pacontstatcb3 { get; set; }
        public byte Pacontstatcb4 { get; set; }
        public byte Pacontstatcb5 { get; set; }
        public byte Pacontstatcb6 { get; set; }
        public byte Pacontstatcb7 { get; set; }
        public byte Pacontstatcb8 { get; set; }
        public byte Pacontstatcb9 { get; set; }
        public byte Pacontstatcb10 { get; set; }
        public string Paprojectstatus1 { get; set; } = null!;
        public string Paprojectstatus2 { get; set; } = null!;
        public string Paprojectstatus3 { get; set; } = null!;
        public string Paprojectstatus4 { get; set; } = null!;
        public string Paprojectstatus5 { get; set; } = null!;
        public string Paprojectstatus6 { get; set; } = null!;
        public string Paprojectstatus7 { get; set; } = null!;
        public string Paprojectstatus8 { get; set; } = null!;
        public string Paprojectstatus9 { get; set; } = null!;
        public string Paprojectstatus10 { get; set; } = null!;
        public byte Paporjstatcb1 { get; set; }
        public byte Paporjstatcb2 { get; set; }
        public byte Paporjstatcb3 { get; set; }
        public byte Paporjstatcb4 { get; set; }
        public byte Paporjstatcb5 { get; set; }
        public byte Paporjstatcb6 { get; set; }
        public byte Paporjstatcb7 { get; set; }
        public byte Paporjstatcb8 { get; set; }
        public byte Paporjstatcb9 { get; set; }
        public byte Paporjstatcb10 { get; set; }
        public byte PausePayCodes { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short TmWipSrc { get; set; }
        public short TmCogsSrc { get; set; }
        public short TmCostContraSrc { get; set; }
        public short TmUnbilledArSrc { get; set; }
        public short TmUnbilledRevSrc { get; set; }
        public short TmArSrc { get; set; }
        public short TmPrjRevSrc { get; set; }
        public short TmOvhdSrc { get; set; }
        public short FfWipSrc { get; set; }
        public short FfCostContraSrc { get; set; }
        public short FfArSrc { get; set; }
        public short FfPrjBillingsSrc { get; set; }
        public short FfPrjExpenseSrc { get; set; }
        public short FfPrjRevenueSrc { get; set; }
        public short FfPrjLossSrc { get; set; }
        public short FfBieeSrc { get; set; }
        public short FfEiebSrc { get; set; }
        public short FfOvhdSrc { get; set; }
        public short TmPrjDeferredRevFee { get; set; }
        public short TmPrjRevFeeSrc { get; set; }
        public short TmArFeeSrc { get; set; }
        public short TmBieeFeeSrc { get; set; }
        public short TmEiebFeeSrc { get; set; }
        public short FfWipFeeSrc { get; set; }
        public short FfPrjBillingsFeeSrc { get; set; }
        public short PaffArFeeSrc { get; set; }
        public short FfPrjRevFeeSrc { get; set; }
        public short FfRetentionFeeSrc { get; set; }
        public short FfPrjDeferredRevFee { get; set; }
        public short FfBieeFeeSrc { get; set; }
        public short FfEiebFeeSrc { get; set; }
        public byte Paincprchtxprjcst { get; set; }
        public byte Patrkchgords { get; set; }
        public byte Patrkcobdgaddfly { get; set; }
        public byte Paallow1 { get; set; }
        public byte Paallow2 { get; set; }
        public byte Paallow3 { get; set; }
        public byte Paallow4 { get; set; }
        public byte Paallow5 { get; set; }
        public byte Paallow6 { get; set; }
        public byte Paallow7 { get; set; }
        public byte Paallow8 { get; set; }
        public byte Paallow9 { get; set; }
        public byte Paallow10 { get; set; }
        public byte Paallow11 { get; set; }
        public byte Paallow12 { get; set; }
        public byte Paallow13 { get; set; }
        public string Papasswordoptions1 { get; set; } = null!;
        public string Papasswordoptions2 { get; set; } = null!;
        public string Papasswordoptions3 { get; set; } = null!;
        public string Papasswordoptions4 { get; set; } = null!;
        public string Papasswordoptions5 { get; set; } = null!;
        public string Papasswordoptions6 { get; set; } = null!;
        public string Papasswordoptions7 { get; set; } = null!;
        public string Papasswordoptions8 { get; set; } = null!;
        public string Papasswordoptions9 { get; set; } = null!;
        public string Papasswordoptions10 { get; set; } = null!;
        public string Papasswordoptions11 { get; set; } = null!;
        public string Papasswordoptions12 { get; set; } = null!;
        public string Papasswordoptions13 { get; set; } = null!;
        public string Padexcriptionoptions1 { get; set; } = null!;
        public string Padexcriptionoptions2 { get; set; } = null!;
        public string Padexcriptionoptions3 { get; set; } = null!;
        public string Padexcriptionoptions4 { get; set; } = null!;
        public string Padexcriptionoptions5 { get; set; } = null!;
        public string Padexcriptionoptions6 { get; set; } = null!;
        public string Padexcriptionoptions7 { get; set; } = null!;
        public string Padexcriptionoptions8 { get; set; } = null!;
        public string Padexcriptionoptions9 { get; set; } = null!;
        public string Padexcriptionoptions10 { get; set; } = null!;
        public string Padexcriptionoptions11 { get; set; } = null!;
        public string Padexcriptionoptions12 { get; set; } = null!;
        public string Padexcriptionoptions13 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
