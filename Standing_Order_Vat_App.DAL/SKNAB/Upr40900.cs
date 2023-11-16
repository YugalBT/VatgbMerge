using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40900
    {
        public string Deducton { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Inactive { get; set; }
        public DateTime Dedbegdt { get; set; }
        public DateTime Dedenddt { get; set; }
        public byte Vardedtn { get; set; }
        public short Dednfreq { get; set; }
        public byte Txshanty { get; set; }
        public byte Sfrfedtx { get; set; }
        public byte Shfrfica { get; set; }
        public byte Shfrsttx { get; set; }
        public byte Sfrlcltx { get; set; }
        public short Bsdorcds { get; set; }
        public short Dednmthd { get; set; }
        public short Dedfrmla { get; set; }
        public decimal Dedcamnt1 { get; set; }
        public decimal Dedcamnt2 { get; set; }
        public decimal Dedcamnt3 { get; set; }
        public decimal Dedcamnt4 { get; set; }
        public decimal Dedcamnt5 { get; set; }
        public decimal Dednprct1 { get; set; }
        public decimal Dednprct2 { get; set; }
        public decimal Dednprct3 { get; set; }
        public decimal Dednprct4 { get; set; }
        public decimal Dednprct5 { get; set; }
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
        public decimal Depyprmx { get; set; }
        public decimal Dedyrmax { get; set; }
        public decimal Dedltmax { get; set; }
        public short W2bxnmbr { get; set; }
        public string W2bxlabl { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Dataentdflt { get; set; }
        public int DexRowId { get; set; }
    }
}
