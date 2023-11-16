using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2tra03
    {
        public string CourseidI { get; set; } = null!;
        public string IclassidI { get; set; } = null!;
        public string ClassnameI { get; set; } = null!;
        public DateTime ClassstartdateI { get; set; }
        public DateTime ClassenddateI { get; set; }
        public string ClassstarttimeI { get; set; } = null!;
        public string ClassendtimeI { get; set; } = null!;
        public string InstructorI { get; set; } = null!;
        public string RoomI { get; set; } = null!;
        public int NumberenrolledI { get; set; }
        public int MaxnumberI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
