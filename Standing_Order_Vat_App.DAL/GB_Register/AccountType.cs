using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.GB_Register
{
    public partial class AccountType
    {
        public AccountType()
        {
            DormantRegisters = new HashSet<DormantRegister>();
        }

        public int AcctTypeId { get; set; }
        public string AcctTypeDesc { get; set; } = null!;

        public virtual ICollection<DormantRegister> DormantRegisters { get; set; }
    }
}
