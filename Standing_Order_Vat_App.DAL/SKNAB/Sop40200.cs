using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sop40200
    {
        public string Docid { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public short Soptype { get; set; }
        public short Setupkey { get; set; }
        public string Doctyabr { get; set; } = null!;
        public string Sopnumbe { get; set; } = null!;
        public string Commntid { get; set; } = null!;
        public short Docuform { get; set; }
        public short Daytoexp { get; set; }
        public byte Allrepea { get; set; }
        public short Allocaby { get; set; }
        public byte Useprosp { get; set; }
        public byte Usnxtinv { get; set; }
        public byte Uspfulpr { get; set; }
        public byte Quotoinv { get; set; }
        public byte Quotoord { get; set; }
        public byte Invtobac { get; set; }
        public byte Bactoinv { get; set; }
        public byte Bactoord { get; set; }
        public byte Ordtobac { get; set; }
        public byte Ordtoord { get; set; }
        public string Usdocid1 { get; set; } = null!;
        public string Usdocid2 { get; set; } = null!;
        public short Qtydefau { get; set; }
        public byte Sopallow1 { get; set; }
        public byte Sopallow2 { get; set; }
        public byte Sopallow3 { get; set; }
        public byte Sopallow4 { get; set; }
        public byte Sopallow5 { get; set; }
        public byte Sopallow6 { get; set; }
        public byte Sopallow7 { get; set; }
        public byte Sopallow8 { get; set; }
        public byte Sopallow9 { get; set; }
        public byte Sopallow10 { get; set; }
        public string Soppsswd1 { get; set; } = null!;
        public string Soppsswd2 { get; set; } = null!;
        public string Soppsswd3 { get; set; } = null!;
        public string Soppsswd4 { get; set; } = null!;
        public string Soppsswd5 { get; set; } = null!;
        public string Soppsswd6 { get; set; } = null!;
        public string Soppsswd7 { get; set; } = null!;
        public string Soppsswd8 { get; set; } = null!;
        public string Soppsswd9 { get; set; } = null!;
        public string Soppsswd10 { get; set; } = null!;
        public short Sopseqnc1 { get; set; }
        public short Sopseqnc2 { get; set; }
        public short Sopseqnc3 { get; set; }
        public short Sopseqnc4 { get; set; }
        public short Sopseqnc5 { get; set; }
        public short Sopseqnc6 { get; set; }
        public short Sopseqnc7 { get; set; }
        public short Sopseqnc8 { get; set; }
        public string User2ent { get; set; } = null!;
        public DateTime Creatddt { get; set; }
        public DateTime Modifdt { get; set; }
        public byte Shppgdoc { get; set; }
        public byte Corrctn { get; set; }
        public byte Simplifd { get; set; }
        public byte Allbackodprt { get; set; }
        public byte Xordinvc { get; set; }
        public string Usdocid3 { get; set; } = null!;
        public byte Workflowenabled { get; set; }
        public byte Updtonprint { get; set; }
        public string Creditlimitholdid { get; set; } = null!;
        public byte Updtactualshpdt { get; set; }
        public string Workflowholdid { get; set; } = null!;
        public byte Overrideivcbillqty { get; set; }
        public byte Enablebackorder { get; set; }
        public byte Enablecanceled { get; set; }
        public byte Sopstatusactive1 { get; set; }
        public byte Sopstatusactive2 { get; set; }
        public byte Sopstatusactive3 { get; set; }
        public byte Sopstatusactive4 { get; set; }
        public byte Sopstatusactive5 { get; set; }
        public byte Sopstatusactive6 { get; set; }
        public byte Sopstatusactive7 { get; set; }
        public byte Sopstatusactive8 { get; set; }
        public byte Sopstatusactive9 { get; set; }
        public int DexRowId { get; set; }
    }
}
