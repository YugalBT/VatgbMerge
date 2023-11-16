using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Fa49900
    {
        public short Cmpanyid { get; set; }
        public short Orgsegment { get; set; }
        public short Acctsegment { get; set; }
        public short Projsegment { get; set; }
        public int Corpbookindx { get; set; }
        public byte Userdataautofmt { get; set; }
        public byte Reqaccount { get; set; }
        public string Usrfld1prompt { get; set; } = null!;
        public short Usrfield1fmt { get; set; }
        public string Usrfld2prompt { get; set; } = null!;
        public short Usrfield2fmt { get; set; }
        public string Usrfld3prompt { get; set; } = null!;
        public short Usrfield3fmt { get; set; }
        public string Usrfld4prompt { get; set; } = null!;
        public short Usrfield4fmt { get; set; }
        public string Usrfld5prompt { get; set; } = null!;
        public short Usrfield5fmt { get; set; }
        public string Usrfld6prompt { get; set; } = null!;
        public short Usrfield6fmt { get; set; }
        public string Usrfld7prompt { get; set; } = null!;
        public short Usrfield7fmt { get; set; }
        public string Usrfld8prompt { get; set; } = null!;
        public short Usrfield8fmt { get; set; }
        public string Usrfld9prompt { get; set; } = null!;
        public short Usrfield9fmt { get; set; }
        public string Usrfld10prompt { get; set; } = null!;
        public short Usrfield10fmt { get; set; }
        public string Usrfld11prompt { get; set; } = null!;
        public short Usrfield11fmt { get; set; }
        public string Usrfld12prompt { get; set; } = null!;
        public short Usrfield12fmt { get; set; }
        public string Usrfld13prompt { get; set; } = null!;
        public short Usrfield13fmt { get; set; }
        public string Usrfld14prompt { get; set; } = null!;
        public short Usrfield14fmt { get; set; }
        public string Usrfld15prompt { get; set; } = null!;
        public short Usrfield15fmt { get; set; }
        public byte ListValidValues1 { get; set; }
        public byte ListValidValues2 { get; set; }
        public byte ListValidValues3 { get; set; }
        public byte ListValidValues4 { get; set; }
        public byte ListValidValues5 { get; set; }
        public byte ListValidValues6 { get; set; }
        public byte ListValidValues7 { get; set; }
        public byte ListValidValues8 { get; set; }
        public byte ListValidValues9 { get; set; }
        public byte ListValidValues10 { get; set; }
        public byte ValidDate1 { get; set; }
        public byte ValidDate2 { get; set; }
        public byte ValidDate3 { get; set; }
        public byte ValidDate4 { get; set; }
        public byte PostTableDeleteOption { get; set; }
        public short PoSystemUsed { get; set; }
        public byte ApPostOption { get; set; }
        public byte FaPostFromPop { get; set; }
        public short PopPostOption { get; set; }
        public byte IncludeMatchingInvoice { get; set; }
        public short FaCountry { get; set; }
        public byte AutoAddBookInfo { get; set; }
        public byte DefltAssetLblFromId { get; set; }
        public byte ValidateCustodian { get; set; }
        public int Deprexpacctindx { get; set; }
        public int Deprresvacctindx { get; set; }
        public int Prioryrdepracctindx { get; set; }
        public int Assetcostacctindx { get; set; }
        public int Proceedsacctindx { get; set; }
        public int Recgainlossacctindx { get; set; }
        public int Nonrecgainlossacctindx { get; set; }
        public int Clearingacctindx { get; set; }
        public decimal Noteindx { get; set; }
        public DateTime Lastmntddate { get; set; }
        public DateTime Lastmntdtime { get; set; }
        public string Lastmntduserid { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
