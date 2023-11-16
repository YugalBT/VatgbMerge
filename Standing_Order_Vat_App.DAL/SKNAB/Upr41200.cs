using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upr41200
    {
        public string Emplclas { get; set; } = null!;
        public string Dscriptn { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public decimal Minetpay { get; set; }
        public short Wkhrpryr { get; set; }
        public short Wcacfpay { get; set; }
        public int Actindx { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public byte Atacrvac { get; set; }
        public short Vaccrmth { get; set; }
        public int Vaccramt { get; set; }
        public int Vacapryr { get; set; }
        public int Vacavlbl { get; set; }
        public byte Wrnvcnflsblwzr { get; set; }
        public byte Atacrstm { get; set; }
        public short Stmacmth { get; set; }
        public int Sktmacam { get; set; }
        public int Sktmhpyr { get; set; }
        public int Siktimav { get; set; }
        public byte Wrnstflsblwzr { get; set; }
        public byte Defltcls { get; set; }
        public byte CalcMinWageBal { get; set; }
        public short Employmenttype { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
