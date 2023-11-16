using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr40600
    {
        public string Payrcord { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public byte Inactive { get; set; }
        public short Paytype { get; set; }
        public string Bspayrcd { get; set; } = null!;
        public decimal Payrtamt { get; set; }
        public string Payunit { get; set; } = null!;
        public short Payunper { get; set; }
        public short Payperod { get; set; }
        public decimal Payprprd { get; set; }
        public decimal Mxpypper { get; set; }
        public short TipType { get; set; }
        public decimal Payadvnc { get; set; }
        public byte Rptaswgs { get; set; }
        public short W2bxnmbr { get; set; }
        public string W2bxlabl { get; set; } = null!;
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
        public byte Acruvacn { get; set; }
        public byte Acrustim { get; set; }
        public decimal Noteindx { get; set; }
        public byte Dataentdflt { get; set; }
        public string Shftcode { get; set; } = null!;
        public decimal Payfactr { get; set; }
        public decimal Bsdonrte { get; set; }
        public int DexRowId { get; set; }
    }
}
