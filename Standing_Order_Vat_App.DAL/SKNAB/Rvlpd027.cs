using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd027
    {
        public short Remtype { get; set; }
        public string Remitid { get; set; } = null!;
        public string Pmtdocid { get; set; } = null!;
        public short OrigPmntDocStatus { get; set; }
        public string Oricbook { get; set; } = null!;
        public string Descbook { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Mcstruct1 { get; set; } = null!;
        public short Mcstruct2 { get; set; }
        public string Mcstruct3 { get; set; } = null!;
        public string Mcstruct4 { get; set; } = null!;
        public decimal Mcstruct5 { get; set; }
        public DateTime Mcstruct6 { get; set; }
        public short Mcstruct7 { get; set; }
        public DateTime Mcstruct8 { get; set; }
        public short Mcstruct9 { get; set; }
        public short Mcstruct10 { get; set; }
        public short Mcstruct11 { get; set; }
        public DateTime Mcstruct12 { get; set; }
        public decimal Mcstruct13 { get; set; }
        public short Mcstruct14 { get; set; }
        public DateTime Trxdate { get; set; }
        public DateTime Pstgdate { get; set; }
        public string Bankacct { get; set; } = null!;
        public decimal Commamnt { get; set; }
        public int Actindx { get; set; }
        public short Remtstat { get; set; }
        public int Numoftrx { get; set; }
        public decimal Functamt { get; set; }
        public decimal Origamt { get; set; }
        public decimal CmrecordNumber { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
