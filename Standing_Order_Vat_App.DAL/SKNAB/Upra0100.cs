using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Upra0100
    {
        public string Employid { get; set; } = null!;
        public string Emplclas { get; set; } = null!;
        public byte Inactive { get; set; }
        public string Lastname { get; set; } = null!;
        public string Frstname { get; set; } = null!;
        public string Midlname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Socscnum { get; set; } = null!;
        public DateTime Brthdate { get; set; }
        public short Gender { get; set; }
        public short Ethnorgn { get; set; }
        public byte CalcMinWageBal { get; set; }
        public string DivisioncodeI { get; set; } = null!;
        public string Deprtmnt { get; set; } = null!;
        public string Jobtitle { get; set; } = null!;
        public string SupervisorcodeI { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public short Wcacfpay { get; set; }
        public int Actindx { get; set; }
        public short Wkhrpryr { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Dempinac { get; set; }
        public string Rsnempin { get; set; } = null!;
        public decimal Minetpay { get; set; }
        public string Sutastat { get; set; } = null!;
        public string Wrkrcomp { get; set; } = null!;
        public byte Atacrvac { get; set; }
        public int Vaccramt { get; set; }
        public short Vaccrmth { get; set; }
        public int Vacapryr { get; set; }
        public int Vacavlbl { get; set; }
        public byte Wrnvcnflsblwzr { get; set; }
        public byte Atacrstm { get; set; }
        public short Stmacmth { get; set; }
        public int Sktmacam { get; set; }
        public int Siktimav { get; set; }
        public int Sktmhpyr { get; set; }
        public byte Wrnstflsblwzr { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public short Employmenttype { get; set; }
        public short Maritalstatus { get; set; }
        public DateTime Benadjdate { get; set; }
        public DateTime LastdayworkedI { get; set; }
        public short Birthday { get; set; }
        public short Birthmonth { get; set; }
        public string Spouse { get; set; } = null!;
        public string Spousessn { get; set; } = null!;
        public string Nickname { get; set; } = null!;
        public string Alternatename { get; set; } = null!;
        public short Hrstatus { get; set; }
        public DateTime DateoflastreviewI { get; set; }
        public DateTime DateofnextreviewI { get; set; }
        public DateTime BenefitexpireI { get; set; }
        public byte Handicapped { get; set; }
        public byte Veteran { get; set; }
        public byte Vietnamveteran { get; set; }
        public byte Disabledveteran { get; set; }
        public byte Unionemployee { get; set; }
        public byte SmokerI { get; set; }
        public byte Citizen { get; set; }
        public byte Verified { get; set; }
        public DateTime I9renew { get; set; }
        public string PrimaryPayRecord { get; set; } = null!;
        public string ChangebyI { get; set; } = null!;
        public DateTime ChangedateI { get; set; }
        public decimal Noteindx { get; set; }
        public decimal Noteindx2 { get; set; }
        public string Unioncd { get; set; } = null!;
        public string Rateclss { get; set; } = null!;
        public string Fedclsscd { get; set; } = null!;
        public byte Othervet { get; set; }
        public DateTime MilitaryDischargeDate { get; set; }
        public int DexRowId { get; set; }
    }
}
