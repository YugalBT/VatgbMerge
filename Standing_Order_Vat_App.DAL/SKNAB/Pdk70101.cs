using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pdk70101
    {
        public string Userid { get; set; } = null!;
        public string PdkStartDocNo { get; set; } = null!;
        public string PdkEndDocNo { get; set; } = null!;
        public string Pastprojn { get; set; } = null!;
        public string Paenprojn { get; set; } = null!;
        public string StartContractNumber { get; set; } = null!;
        public string EndContractNumber { get; set; } = null!;
        public string PastartIdArray1 { get; set; } = null!;
        public string PastartIdArray2 { get; set; } = null!;
        public string PastartIdArray3 { get; set; } = null!;
        public string PastartIdArray4 { get; set; } = null!;
        public string PastartIdArray5 { get; set; } = null!;
        public string PastartIdArray6 { get; set; } = null!;
        public string PastartIdArray7 { get; set; } = null!;
        public string PastartIdArray8 { get; set; } = null!;
        public string PastartIdArray9 { get; set; } = null!;
        public string PastartIdArray10 { get; set; } = null!;
        public string PaendIdArray1 { get; set; } = null!;
        public string PaendIdArray2 { get; set; } = null!;
        public string PaendIdArray3 { get; set; } = null!;
        public string PaendIdArray4 { get; set; } = null!;
        public string PaendIdArray5 { get; set; } = null!;
        public string PaendIdArray6 { get; set; } = null!;
        public string PaendIdArray7 { get; set; } = null!;
        public string PaendIdArray8 { get; set; } = null!;
        public string PaendIdArray9 { get; set; } = null!;
        public string PaendIdArray10 { get; set; } = null!;
        public string PastartNameArray1 { get; set; } = null!;
        public string PastartNameArray2 { get; set; } = null!;
        public string PastartNameArray3 { get; set; } = null!;
        public string PastartNameArray4 { get; set; } = null!;
        public string PastartNameArray5 { get; set; } = null!;
        public string PastartNameArray6 { get; set; } = null!;
        public string PastartNameArray7 { get; set; } = null!;
        public string PastartNameArray8 { get; set; } = null!;
        public string PastartNameArray9 { get; set; } = null!;
        public string PastartNameArray10 { get; set; } = null!;
        public string PaendNameArray1 { get; set; } = null!;
        public string PaendNameArray2 { get; set; } = null!;
        public string PaendNameArray3 { get; set; } = null!;
        public string PaendNameArray4 { get; set; } = null!;
        public string PaendNameArray5 { get; set; } = null!;
        public string PaendNameArray6 { get; set; } = null!;
        public string PaendNameArray7 { get; set; } = null!;
        public string PaendNameArray8 { get; set; } = null!;
        public string PaendNameArray9 { get; set; } = null!;
        public string PaendNameArray10 { get; set; } = null!;
        public DateTime Stdatein { get; set; }
        public DateTime Endatein { get; set; }
        public short Pastdoct { get; set; }
        public short Paendoct { get; set; }
        public short Iffilxst { get; set; }
        public string Filexpnm { get; set; } = null!;
        public short Expttype { get; set; }
        public byte Askechtm { get; set; }
        public byte Prntofil { get; set; }
        public byte Prtoprtr { get; set; }
        public byte Prtoscrn { get; set; }
        public short Prnttype { get; set; }
        public short Rptgrind { get; set; }
        public decimal Rtgrsbin { get; set; }
        public short Rtpachin { get; set; }
        public short Reportid { get; set; }
        public string Rptgrnms { get; set; } = null!;
        public short Patu { get; set; }
        public DateTime Strtngdt { get; set; }
        public DateTime Endingdt { get; set; }
        public string Sttudef1 { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public DateTime Sttdocdt { get; set; }
        public DateTime Enddocdt { get; set; }
        public DateTime Sttpstdt { get; set; }
        public DateTime Endpstdt { get; set; }
        public short Sortby { get; set; }
        public byte ParangeByArray1 { get; set; }
        public byte ParangeByArray2 { get; set; }
        public byte ParangeByArray3 { get; set; }
        public byte ParangeByArray4 { get; set; }
        public byte ParangeByArray5 { get; set; }
        public byte ParangeByArray6 { get; set; }
        public byte ParangeByArray7 { get; set; }
        public byte ParangeByArray8 { get; set; }
        public byte ParangeByArray9 { get; set; }
        public byte ParangeByArray10 { get; set; }
        public byte PaexcludeArray1 { get; set; }
        public byte PaexcludeArray2 { get; set; }
        public byte PaexcludeArray3 { get; set; }
        public byte PaexcludeArray4 { get; set; }
        public byte PaexcludeArray5 { get; set; }
        public byte PaexcludeArray6 { get; set; }
        public byte PaexcludeArray7 { get; set; }
        public byte PaexcludeArray8 { get; set; }
        public byte PaexcludeArray9 { get; set; }
        public byte PaexcludeArray10 { get; set; }
        public short Rangeby { get; set; }
        public short PareportInclude { get; set; }
        public int DexRowId { get; set; }
    }
}
