using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40800
    {
        public string Benefit { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Inactive { get; set; }
        public DateTime Bnfbegdt { get; set; }
        public DateTime Bnfenddt { get; set; }
        public byte Varbenft { get; set; }
        public short Bnftfreq { get; set; }
        public byte Taxable { get; set; }
        public byte Sbjtfdtx { get; set; }
        public byte Sbjtssec { get; set; }
        public byte Sbjtmcar { get; set; }
        public byte Sbjtsttx { get; set; }
        public byte Sbjtltax { get; set; }
        public byte Sbjtfuta { get; set; }
        public byte Sbjtsuta { get; set; }
        public short Ffedtxrt { get; set; }
        public short Flsttxrt { get; set; }
        public short Borcdtyp { get; set; }
        public short Bsdorcds { get; set; }
        public short Bnftmthd { get; set; }
        public short Bnffrmla { get; set; }
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
        public decimal Bnpaypmx { get; set; }
        public decimal Bnfyrmax { get; set; }
        public decimal Bnflfmax { get; set; }
        public short W2bxnmbr { get; set; }
        public string W2bxlabl { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Dataentdflt { get; set; }
        public decimal Emplrmaxmat { get; set; }
        public int DexRowId { get; set; }
    }
}
