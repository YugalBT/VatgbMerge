using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Cn40500
    {
        public string Userid { get; set; } = null!;
        public byte AllowEdNotesOthers { get; set; }
        public byte AllowEdNotesUser { get; set; }
        public byte AllowViewOnlyOwnNote { get; set; }
        public byte OpenCollectProMain { get; set; }
        public byte OpenCollectProQuery { get; set; }
        public byte OpenCollectProToDo { get; set; }
        public string Stcustid { get; set; } = null!;
        public string Stcustnm { get; set; } = null!;
        public string Sttclsid { get; set; } = null!;
        public string Sttudef1 { get; set; } = null!;
        public string Stsprsid { get; set; } = null!;
        public string Stslster { get; set; } = null!;
        public string StartCreditManager { get; set; } = null!;
        public string Encustid { get; set; } = null!;
        public string Encstnam { get; set; } = null!;
        public string Endclsid { get; set; } = null!;
        public string Enusrdf1 { get; set; } = null!;
        public string Enspsnid { get; set; } = null!;
        public string Enslster { get; set; } = null!;
        public string EndCreditManager { get; set; } = null!;
        public string CnEmailAddress { get; set; } = null!;
        public string PositionName { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
