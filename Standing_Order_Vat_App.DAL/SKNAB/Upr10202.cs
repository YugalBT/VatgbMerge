using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr10202
    {
        public string Userid { get; set; } = null!;
        public short Pyrntype { get; set; }
        public string Employid { get; set; } = null!;
        public byte Posted { get; set; }
        public byte Pystltex { get; set; }
        public string Cheknmbr { get; set; } = null!;
        public DateTime Chekdate { get; set; }
        public string Chekbkid { get; set; } = null!;
        public int Pyadnmbr { get; set; }
        public int Actindx { get; set; }
        public decimal Adfdwhdg { get; set; }
        public decimal Estfedwh { get; set; }
        public decimal Hwkvcacr { get; set; }
        public decimal Hwkskacr { get; set; }
        public decimal Vactmacc { get; set; }
        public decimal Sktmaccr { get; set; }
        public decimal Vactmlbl { get; set; }
        public decimal Sktmlbty { get; set; }
        public int Vacavlbl { get; set; }
        public int Siktimav { get; set; }
        public decimal Grwgprn { get; set; }
        public decimal Ntwpyrn { get; set; }
        public decimal Fedwgarr1 { get; set; }
        public decimal Fedwgarr2 { get; set; }
        public decimal Fedwgarr3 { get; set; }
        public decimal Fedwgarr4 { get; set; }
        public decimal Fedwgarr5 { get; set; }
        public decimal Fedwgarr6 { get; set; }
        public decimal Fedwgarr7 { get; set; }
        public decimal Fedwgarr8 { get; set; }
        public decimal FederalTipsArray1 { get; set; }
        public decimal FederalTipsArray2 { get; set; }
        public decimal FederalTipsArray3 { get; set; }
        public decimal FederalTipsArray4 { get; set; }
        public decimal FederalTipsArray5 { get; set; }
        public decimal FederalTipsArray6 { get; set; }
        public decimal FederalTipsArray7 { get; set; }
        public decimal FederalTipsArray8 { get; set; }
        public decimal Fdwgpyrn { get; set; }
        public decimal FederalTipsPayRun { get; set; }
        public decimal Anfdwhdg { get; set; }
        public decimal Fdwdgprn { get; set; }
        public decimal Fdtxtips { get; set; }
        public decimal Ficasswp { get; set; }
        public decimal FicassTipsPayRun { get; set; }
        public decimal Fcaswpr { get; set; }
        public decimal Ficstptx { get; set; }
        public decimal UncollectedFicassTaxP { get; set; }
        public decimal Ficamwgp { get; set; }
        public decimal FicamedTipsPayRun { get; set; }
        public decimal Ficamwpr { get; set; }
        public decimal Ficmtptx { get; set; }
        public decimal UncollectedFicamedTaxP { get; set; }
        public decimal Eicwpyrn { get; set; }
        public decimal Epficass { get; set; }
        public decimal Eficamcr { get; set; }
        public decimal ChargedReceipts { get; set; }
        public decimal ReportedReceipts { get; set; }
        public decimal HoursWorkedForMinimum { get; set; }
        public decimal MinWageBalApplicable { get; set; }
        public decimal ReportedTips { get; set; }
        public decimal ChargedTips { get; set; }
        public decimal Aloctips { get; set; }
        public short TipType { get; set; }
        public DateTime Posteddt { get; set; }
        public decimal Grwgfreic { get; set; }
        public int DexRowId { get; set; }
    }
}
