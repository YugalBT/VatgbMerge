using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00960
    {
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public string Phonname { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string AniNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
