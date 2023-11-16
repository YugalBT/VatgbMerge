using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNANB_LIVE
{
    public partial class VwEmpDetailsPersonal
    {
        public string? StaffNo { get; set; }
        public string? Gender { get; set; }
        public string Ethnicity { get; set; } = null!;
        public string? MaritalStatus { get; set; }
        public string DrivingLicence { get; set; } = null!;
        public string VehicleNumber { get; set; } = null!;
        public string? HomeTel { get; set; }
        public string Mobile { get; set; } = null!;
        public string WorkNumber { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string FaxNumber { get; set; } = null!;
        public string? Email { get; set; }
    }
}
