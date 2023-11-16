using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00100
    {
        public string Vndclsid { get; set; } = null!;
        public string Vndcldsc { get; set; } = null!;
        public byte Defltcls { get; set; }
        public short Mxiafvnd { get; set; }
        public decimal Mxinvamt { get; set; }
        public short Writeoff { get; set; }
        public short Credtlmt { get; set; }
        public short Ten99type { get; set; }
        public short Ptcshacf { get; set; }
        public decimal Mxwofamt { get; set; }
        public decimal Minorder { get; set; }
        public decimal Crlmtdlr { get; set; }
        public string Pymntpri { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public short Minpytyp { get; set; }
        public decimal Minpydlr { get; set; }
        public short Minpypct { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public byte Kpcalhst { get; set; }
        public byte Kgldsths { get; set; }
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public short Trddisct { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public int Pmapindx { get; set; }
        public int Pmcshidx { get; set; }
        public int Pmdavidx { get; set; }
        public int Pmdtkidx { get; set; }
        public int Pmfinidx { get; set; }
        public int Pmmschix { get; set; }
        public int Pmfrtidx { get; set; }
        public int Pmtaxidx { get; set; }
        public int Pmwrtidx { get; set; }
        public int Pmprchix { get; set; }
        public int Pmrtngix { get; set; }
        public int Pmtdscix { get; set; }
        public int Acpuridx { get; set; }
        public int Purpvidx { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public string Ratetpid { get; set; } = null!;
        public byte RevalueVendor { get; set; }
        public short PostResultsTo { get; set; }
        public short Freeonboard { get; set; }
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public byte TaxInvRecvd { get; set; }
        public byte Cbvat { get; set; }
        public int DexRowId { get; set; }
    }
}
