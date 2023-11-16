using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben40
    {
        public string EmpidI { get; set; } = null!;
        public DateTime Bnfbegdt { get; set; }
        public string Benefit { get; set; } = null!;
        public short I1I { get; set; }
        public byte Check1I { get; set; }
        public short TiermethodI { get; set; }
        public short Bnftmthd { get; set; }
        public decimal Bnfprcnt1 { get; set; }
        public decimal Bnfprcnt2 { get; set; }
        public decimal Bnfprcnt3 { get; set; }
        public decimal Bnfprcnt4 { get; set; }
        public decimal Bnfprcnt5 { get; set; }
        public decimal Bnfitamt1 { get; set; }
        public decimal Bnfitamt2 { get; set; }
        public decimal Bnfitamt3 { get; set; }
        public decimal Bnfitamt4 { get; set; }
        public decimal Bnfitamt5 { get; set; }
        public decimal Bnftrmax1 { get; set; }
        public decimal Bnftrmax2 { get; set; }
        public decimal Bnftrmax3 { get; set; }
        public decimal Bnftrmax4 { get; set; }
        public decimal Bnftrmax5 { get; set; }
        public int Bntrmxun1 { get; set; }
        public int Bntrmxun2 { get; set; }
        public int Bntrmxun3 { get; set; }
        public int Bntrmxun4 { get; set; }
        public int Bntrmxun5 { get; set; }
        public short Dednmthd { get; set; }
        public decimal Dednprct1 { get; set; }
        public decimal Dednprct2 { get; set; }
        public decimal Dednprct3 { get; set; }
        public decimal Dednprct4 { get; set; }
        public decimal Dednprct5 { get; set; }
        public decimal Dedcamnt1 { get; set; }
        public decimal Dedcamnt2 { get; set; }
        public decimal Dedcamnt3 { get; set; }
        public decimal Dedcamnt4 { get; set; }
        public decimal Dedcamnt5 { get; set; }
        public decimal Dedtrmax1 { get; set; }
        public decimal Dedtrmax2 { get; set; }
        public decimal Dedtrmax3 { get; set; }
        public decimal Dedtrmax4 { get; set; }
        public decimal Dedtrmax5 { get; set; }
        public int Detrmxun1 { get; set; }
        public int Detrmxun2 { get; set; }
        public int Detrmxun3 { get; set; }
        public int Detrmxun4 { get; set; }
        public int Detrmxun5 { get; set; }
        public int DexRowId { get; set; }
    }
}
