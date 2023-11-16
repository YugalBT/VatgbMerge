using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Be020230
    {
        public string Benefit { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public short BenefitstatusI { get; set; }
        public short CompletionstatusI { get; set; }
        public byte Inactive { get; set; }
        public short BenefitkindI { get; set; }
        public DateTime Bnfbegdt { get; set; }
        public DateTime Bnfenddt { get; set; }
        public byte Varbenft { get; set; }
        public short Bnftfreq { get; set; }
        public string Carrier { get; set; } = null!;
        public string GroupnumberI { get; set; } = null!;
        public byte PortablebenefitI { get; set; }
        public short PorableindexI { get; set; }
        public short MaxageempI { get; set; }
        public short MaxagedepI { get; set; }
        public short MaxagespI { get; set; }
        public decimal CostemployeeI { get; set; }
        public decimal CostemployerI { get; set; }
        public decimal Costother1I { get; set; }
        public decimal Costother2I { get; set; }
        public short I1I { get; set; }
        public short I2I { get; set; }
        public short I3I { get; set; }
        public short I4I { get; set; }
        public short GbI { get; set; }
        public decimal CosttotalI { get; set; }
        public decimal CostcobraI { get; set; }
        public decimal BenamountI { get; set; }
        public decimal BenefitdeductibleI { get; set; }
        public decimal Bnpaypmx { get; set; }
        public decimal Bnfyrmax { get; set; }
        public decimal Bnflfmax { get; set; }
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal NotesindexI { get; set; }
        public decimal NearestI { get; set; }
        public decimal NearestchildI { get; set; }
        public decimal NearestspouseI { get; set; }
        public decimal NearestemployerI { get; set; }
        public short PremmethodI { get; set; }
        public decimal PremiumemployeeI { get; set; }
        public decimal PremiumspouseI { get; set; }
        public decimal PremiumchildI { get; set; }
        public decimal PremiumemployerI { get; set; }
        public decimal PremiumsmokerI { get; set; }
        public short FactorI { get; set; }
        public byte RoundupI { get; set; }
        public byte PdlifeI { get; set; }
        public decimal ContempmatchI { get; set; }
        public decimal ContribemployermaxI { get; set; }
        public short MinageI { get; set; }
        public byte BonuselactiveI { get; set; }
        public byte LoansallowedI { get; set; }
        public byte HardshpwithdrawI { get; set; }
        public short TypeofcodeI { get; set; }
        public decimal ContribdollarI { get; set; }
        public decimal ContribpercentI { get; set; }
        public short MajmedcoverageI { get; set; }
        public decimal MaxoutofpocketI { get; set; }
        public short WaitingperiodI { get; set; }
        public short Bnftmthd { get; set; }
        public short Bnffrmla { get; set; }
        public decimal Bnfprcnt1 { get; set; }
        public decimal Bnfprcnt2 { get; set; }
        public decimal Bnfprcnt3 { get; set; }
        public decimal Bnfprcnt4 { get; set; }
        public decimal Bnfprcnt5 { get; set; }
        public short Dednmthd { get; set; }
        public short Dedfrmla { get; set; }
        public decimal Dednprct1 { get; set; }
        public decimal Dednprct2 { get; set; }
        public decimal Dednprct3 { get; set; }
        public decimal Dednprct4 { get; set; }
        public decimal Dednprct5 { get; set; }
        public decimal Depyprmx { get; set; }
        public decimal Dedyrmax { get; set; }
        public decimal Dedltmax { get; set; }
        public byte Inactbenemployee { get; set; }
        public byte Inactbenemplr { get; set; }
        public int DexRowId { get; set; }
    }
}
