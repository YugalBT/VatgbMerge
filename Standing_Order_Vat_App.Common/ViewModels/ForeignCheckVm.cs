﻿using Standing_Order_Vat_App.Common.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GbRegister.Core.ViewModel
{
    public class ForeignCheckVm
    {

        public long RecordId { get; set; } = 1234567;
        public string CheckNumber { get; set; } = null!;
        public string PayerAcctNumber { get; set; } = null!;
        public string PayerAcctName { get; set; } = null!;
        public string DepositAcctNumber { get; set; } = null!;
        public string DepositAcctName { get; set; } = null!;
        public decimal CheckAmount { get; set; }
        public decimal TotalAmount { get; set; }
        public int BatchId { get; set; } 
        public DateTime DateRecived { get; set; }
        public int BankId { get; set; }
        public List<BankListVm> BanksList { get; set; }
        public List<FrgnCheckListVm> checksList { get; set; }

    }
}