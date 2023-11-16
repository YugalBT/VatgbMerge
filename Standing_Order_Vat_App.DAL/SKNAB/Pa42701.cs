using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa42701
    {
        public short Pasetupkey { get; set; }
        public string PainventoryCounter { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string PauserDefinedPrompt1Iv { get; set; } = null!;
        public string PauserDefinedPrompt2Iv { get; set; } = null!;
        public string PacostDescriptionIv { get; set; } = null!;
        public short Padescriptionfrom { get; set; }
        public short PapriceLevelFromIv { get; set; }
        public byte Trkvdtrx { get; set; }
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
        public string Padexcriptionoptions1 { get; set; } = null!;
        public string Padexcriptionoptions2 { get; set; } = null!;
        public string Padexcriptionoptions3 { get; set; } = null!;
        public string Padexcriptionoptions4 { get; set; } = null!;
        public string Padexcriptionoptions5 { get; set; } = null!;
        public string Padexcriptionoptions6 { get; set; } = null!;
        public string Padexcriptionoptions7 { get; set; } = null!;
        public string Padexcriptionoptions8 { get; set; } = null!;
        public string Padexcriptionoptions9 { get; set; } = null!;
        public string Padexcriptionoptions10 { get; set; } = null!;
        public string Padexcriptionoptions11 { get; set; } = null!;
        public string Padexcriptionoptions12 { get; set; } = null!;
        public string Padexcriptionoptions13 { get; set; } = null!;
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
        public byte Pacbnotrnsfrbillnts { get; set; }
        public byte Padonotalliv { get; set; }
        public int DexRowId { get; set; }
    }
}
