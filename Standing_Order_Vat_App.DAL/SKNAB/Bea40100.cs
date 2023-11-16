using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bea40100
    {
        public string EmpidI { get; set; } = null!;
        public short IcInstanceNumberI { get; set; }
        public DateTime EffectivedateI { get; set; }
        public string LlastnameI { get; set; } = null!;
        public string FfirstnameI { get; set; } = null!;
        public string MiI { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string ZipcodeI { get; set; } = null!;
        public string Homephone { get; set; } = null!;
        public DateTime DateofbirthI { get; set; }
        public short Relationship { get; set; }
        public string DepssnI { get; set; } = null!;
        public string SsnI { get; set; } = null!;
        public DateTime BenefitexpireI { get; set; }
        public DateTime Bnfbegdt { get; set; }
        public short CobraqeI { get; set; }
        public string Commentstr20 { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public decimal IcInitialBalanceI { get; set; }
        public decimal CostcobraI { get; set; }
        public short IcMonthsIntI { get; set; }
        public short IcCobraMonthDdlI { get; set; }
        public short IcCobraDependentDdlI { get; set; }
        public short IcCobraEmployeeDdlI { get; set; }
        public short IbenefitfrequencyI { get; set; }
        public DateTime IcFirstPaymentDateI { get; set; }
        public DateTime IcLastPaymentDateI { get; set; }
        public byte IcAutoPostCbI { get; set; }
        public DateTime IcNextAutoPostDateI { get; set; }
        public int DexRowId { get; set; }
    }
}
