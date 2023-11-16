using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa01100
    {
        public string Custnmbr { get; set; } = null!;
        public string Pacontid { get; set; } = null!;
        public string Pacontname { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string PacontMgrId { get; set; } = null!;
        public string PabusMgrId { get; set; } = null!;
        public short Pastat { get; set; }
        public byte PasegmentCb { get; set; }
        public DateTime PabbeginDate { get; set; }
        public DateTime PabendDate { get; set; }
        public decimal PaprojectAmount { get; set; }
        public string Custname { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
