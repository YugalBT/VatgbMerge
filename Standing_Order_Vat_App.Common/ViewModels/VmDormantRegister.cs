﻿using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GbRegister.Core.ViewModel
{
    public class VmDormantRegister
    {
        public int RecordId { get; set; }

        [Required (ErrorMessage="Date Requested is required")]
        public DateTime? DateRequested { get; set; }

        [Required(ErrorMessage="Account Number is required")]
        public string? AcctNumber { get; set; } = null!;

        [Required(ErrorMessage="Name is required")]
        public string? Name { get; set; } = null!;

        public decimal? PreviousBalance { get; set; }

        public string? Particulars { get; set; }

        public int? InitialIdEmployee { get; set; }

        public int? ReactivateIdEmployee { get; set; }

        public DateTime? DatePerformed { get; set; }

        public int? EntryStatusId { get; set; }

        public int? AcctTypeId { get; set; }

        public string? CoreBranchNumber { get; set; }

        public int? IssuingDeptId { get; set; }

        [Required(ErrorMessage="Account Status is required")]
        public string? AcctStatus { get; set; }

        [Required(ErrorMessage = "Account Type is required")]
        public string? AcctType { get; set; }

    }

    public class VmDormantRegisterData
    {
        public IEnumerable<VmDormantRegister>? VmDormants { get; set; }
        public int Id { get; set; }
        public List<EntityStatusVM>? EntityStatusVMs { get; set; }
    }


}
