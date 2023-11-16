using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00670
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public short SvcContractVersion { get; set; }
        public string Cnttype { get; set; } = null!;
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public byte History { get; set; }
        public short Rencnttyp { get; set; }
        public string Userid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
