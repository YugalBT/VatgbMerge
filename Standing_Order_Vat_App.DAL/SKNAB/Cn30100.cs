using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn30100
    {
        public string Custnmbr { get; set; } = null!;
        public string Cprcstnm { get; set; } = null!;
        public DateTime Date1 { get; set; }
        public DateTime ContactDate { get; set; }
        public DateTime Time1 { get; set; }
        public DateTime ContactTime { get; set; }
        public decimal Noteindx { get; set; }
        public short RevisionNumber { get; set; }
        public DateTime RevisionDate { get; set; }
        public DateTime RevisionTime { get; set; }
        public byte CnGroupNote { get; set; }
        public string CallerIdString { get; set; } = null!;
        public string ActionPromised { get; set; } = null!;
        public short ActionType { get; set; }
        public DateTime ActionDate { get; set; }
        public string ActionAssignedTo { get; set; } = null!;
        public byte ActionCompleted { get; set; }
        public DateTime ActionCompletedDate { get; set; }
        public DateTime ActionCompletedTime { get; set; }
        public decimal AmountPromised { get; set; }
        public string Userid { get; set; } = null!;
        public string NoteDisplayString { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public DateTime Usrdat01 { get; set; }
        public short Priort { get; set; }
        public string Notecat { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
