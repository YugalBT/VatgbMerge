using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn00600
    {
        public string QueryId { get; set; } = null!;
        public string QueryDescription { get; set; } = null!;
        public string Stcustid { get; set; } = null!;
        public string Stcustnm { get; set; } = null!;
        public string Sttclsid { get; set; } = null!;
        public string Sttudef1 { get; set; } = null!;
        public string Stsprsid { get; set; } = null!;
        public string Stslster { get; set; } = null!;
        public short StartPrefContactMethod { get; set; }
        public short CnstartTimeZone { get; set; }
        public string Strtudef { get; set; } = null!;
        public DateTime Studdat1 { get; set; }
        public string Studtab1 { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Encstnam { get; set; } = null!;
        public string Endclsid { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public string Enspsnid { get; set; } = null!;
        public string Enslster { get; set; } = null!;
        public short CnendTimeZone { get; set; }
        public short EndPrefContactMethod { get; set; }
        public string Enusrdef { get; set; } = null!;
        public DateTime Enduddt1 { get; set; }
        public string Endudtbl { get; set; } = null!;
        public short StartCreditControlCycle { get; set; }
        public short EndCreditControlCyle { get; set; }
        public byte Connaact { get; set; }
        public short DateSelection { get; set; }
        public short Qrystcdtper { get; set; }
        public short QryEndCrLimitPeriod { get; set; }
        public decimal Qrystcdtamt { get; set; }
        public decimal QryEndCreditLimitAmt { get; set; }
        public short QryStartDateToken { get; set; }
        public short QryEndDateToken { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public short StartingTrxDays { get; set; }
        public short EndingTrxDays { get; set; }
        public string StartCallerId { get; set; } = null!;
        public DateTime StartContactDate { get; set; }
        public string StartActionAssignedTo { get; set; } = null!;
        public string StartActionPromised { get; set; } = null!;
        public DateTime StartActionDate { get; set; }
        public short Snotprty { get; set; }
        public short Qryactcom { get; set; }
        public string EndCallerId { get; set; } = null!;
        public DateTime EndContactDate { get; set; }
        public string EndActionAssignedTo { get; set; } = null!;
        public string EndActionPromised { get; set; } = null!;
        public DateTime EndActionDate { get; set; }
        public short Enotprty { get; set; }
        public byte Qcmflag { get; set; }
        public string StartCreditManager { get; set; } = null!;
        public string EndCreditManager { get; set; } = null!;
        public short Custcsts { get; set; }
        public short QueryBalanceReturned { get; set; }
        public byte QueryExcludeOlderBalance { get; set; }
        public byte QryExcludeifPaymentMade { get; set; }
        public short QueryNumberofDays { get; set; }
        public short QueryNoteExists { get; set; }
        public string Studtab2 { get; set; } = null!;
        public string Endudtbl2 { get; set; } = null!;
        public short Userlang { get; set; }
        public short CnCreditLevelStart { get; set; }
        public short CnCreditLevelEnd { get; set; }
        public byte QueryExcludePartialPa { get; set; }
        public int DexRowId { get; set; }
    }
}
