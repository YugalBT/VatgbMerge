using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pm00200
    {
        public string Vendorid { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Vndchknm { get; set; } = null!;
        public string Vendshnm { get; set; } = null!;
        public string Vaddcdpr { get; set; } = null!;
        public string Vadcdpad { get; set; } = null!;
        public string Vadcdsfr { get; set; } = null!;
        public string Vadcdtro { get; set; } = null!;
        public string Vndclsid { get; set; } = null!;
        public string Vndcntct { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public string Phnumbr1 { get; set; } = null!;
        public string Phnumbr2 { get; set; } = null!;
        public string Phone3 { get; set; } = null!;
        public string Faxnumbr { get; set; } = null!;
        public string Upszone { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public string Taxschid { get; set; } = null!;
        public string Acnmvndr { get; set; } = null!;
        public string Txidnmbr { get; set; } = null!;
        public short Vendstts { get; set; }
        public string Curncyid { get; set; } = null!;
        public string Txrgnnum { get; set; } = null!;
        public string Parvenid { get; set; } = null!;
        public short Trddisct { get; set; }
        public short Ten99type { get; set; }
        public decimal Minorder { get; set; }
        public string Pymtrmid { get; set; } = null!;
        public short Minpytyp { get; set; }
        public short Minpypct { get; set; }
        public decimal Minpydlr { get; set; }
        public short Mxiafvnd { get; set; }
        public decimal Maxindlr { get; set; }
        public string Comment1 { get; set; } = null!;
        public string Comment2 { get; set; } = null!;
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public decimal Crlmtdlr { get; set; }
        public string Pymntpri { get; set; } = null!;
        public byte Kpcalhst { get; set; }
        public byte Kgldsths { get; set; }
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public byte Hold { get; set; }
        public short Ptcshacf { get; set; }
        public short Credtlmt { get; set; }
        public short Writeoff { get; set; }
        public decimal Mxwofamt { get; set; }
        public byte Sbppsded { get; set; }
        public short Ppstaxrt { get; set; }
        public string Dxvarnum { get; set; } = null!;
        public DateTime Crtcomdt { get; set; }
        public DateTime Crtexpdt { get; set; }
        public byte Rtobutkn { get; set; }
        public byte Xpdtoblg { get; set; }
        public byte Prspayee { get; set; }
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
        public decimal Noteindx { get; set; }
        public string Chekbkid { get; set; } = null!;
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public string Ratetpid { get; set; } = null!;
        public byte RevalueVendor { get; set; }
        public short PostResultsTo { get; set; }
        public short Freeonboard { get; set; }
        public string Govcrpid { get; set; } = null!;
        public string Govindid { get; set; } = null!;
        public short Disgrper { get; set; }
        public short Duegrper { get; set; }
        public string Docfmtid { get; set; } = null!;
        public byte TaxInvRecvd { get; set; }
        public short Userlang { get; set; }
        public short WithholdingType { get; set; }
        public short WithholdingFormType { get; set; }
        public short WithholdingEntityType { get; set; }
        public short TaxFileNumMode { get; set; }
        public DateTime Brthdate { get; set; }
        public short LaborPmtType { get; set; }
        public string Ccode { get; set; } = null!;
        public string Declid { get; set; } = null!;
        public byte Cbvat { get; set; }
        public int DexRowId { get; set; }
    }
}
