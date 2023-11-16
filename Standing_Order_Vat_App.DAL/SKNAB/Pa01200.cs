using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01200
    {
        public string Custnmbr { get; set; } = null!;
        public short PaacctgMethod { get; set; }
        public string Pacontnumber { get; set; } = null!;
        public decimal PaprojectAmount { get; set; }
        public string Paprojid { get; set; } = null!;
        public string Paprojmngrid { get; set; } = null!;
        public string Paprojname { get; set; } = null!;
        public string Paprojnumber { get; set; } = null!;
        public short PaprojectType { get; set; }
        public byte PasegmentCb { get; set; }
        public short Pastat { get; set; }
        public string Custname { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
