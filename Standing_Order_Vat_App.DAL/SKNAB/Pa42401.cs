using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa42401
    {
        public short Pasetupkey { get; set; }
        public string Paerdefinedprompt1 { get; set; } = null!;
        public string Paerdefinedprompt2 { get; set; } = null!;
        public string Pacostdescer { get; set; } = null!;
        public string Paerdoccounter { get; set; } = null!;
        public short Pavidroaer { get; set; }
        public short Paeeprofittypefrom { get; set; }
        public short Padescriptionfrom { get; set; }
        public short Useadvtx { get; set; }
        public string Taxschid { get; set; } = null!;
        public short PamiscTaxableP { get; set; }
        public string Mscschid { get; set; } = null!;
        public short PafreightTaxableP { get; set; }
        public string Frtschid { get; set; } = null!;
        public byte Paallow1 { get; set; }
        public byte Paallow2 { get; set; }
        public byte Paallow3 { get; set; }
        public byte Paallow4 { get; set; }
        public byte Paallow5 { get; set; }
        public byte Paallow6 { get; set; }
        public byte Paallow7 { get; set; }
        public byte Paallow8 { get; set; }
        public byte Paallow9 { get; set; }
        public byte Paallow10 { get; set; }
        public byte Paallow11 { get; set; }
        public byte Paallow12 { get; set; }
        public byte Paallow13 { get; set; }
        public string Papasswordoptions1 { get; set; } = null!;
        public string Papasswordoptions2 { get; set; } = null!;
        public string Papasswordoptions3 { get; set; } = null!;
        public string Papasswordoptions4 { get; set; } = null!;
        public string Papasswordoptions5 { get; set; } = null!;
        public string Papasswordoptions6 { get; set; } = null!;
        public string Papasswordoptions7 { get; set; } = null!;
        public string Papasswordoptions8 { get; set; } = null!;
        public string Papasswordoptions9 { get; set; } = null!;
        public string Papasswordoptions10 { get; set; } = null!;
        public string Papasswordoptions11 { get; set; } = null!;
        public string Papasswordoptions12 { get; set; } = null!;
        public string Papasswordoptions13 { get; set; } = null!;
        public decimal Pabillnoteidx { get; set; }
        public short PaexpenseType { get; set; }
        public short PapaymentMethod { get; set; }
        public byte PapostoDynPm { get; set; }
        public short PaUpdatePeriodicOpt { get; set; }
        public int DexRowId { get; set; }
    }
}
