using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2tra01
    {
        public string CoursenameI { get; set; } = null!;
        public string CourseidI { get; set; } = null!;
        public string CoursesubjectI { get; set; } = null!;
        public string RoomI { get; set; } = null!;
        public string InstructorI { get; set; } = null!;
        public string CourseprereqsI1 { get; set; } = null!;
        public string CourseprereqsI2 { get; set; } = null!;
        public string CourseprereqsI3 { get; set; } = null!;
        public string CourseprereqsI4 { get; set; } = null!;
        public string CourseprereqsI5 { get; set; } = null!;
        public byte CourseinhouseI { get; set; }
        public decimal CoursecostI { get; set; }
        public decimal EmployeecostI { get; set; }
        public decimal EmployercostI { get; set; }
        public decimal InstructorfeeI { get; set; }
        public decimal MisccostI { get; set; }
        public decimal CredithoursI { get; set; }
        public decimal NotesindexI { get; set; }
        public int DexRowId { get; set; }
    }
}
