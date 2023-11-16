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
        public long BatchId { get; set; } = 24;
        public DateTime DateRecived { get; set; }

    }
}
