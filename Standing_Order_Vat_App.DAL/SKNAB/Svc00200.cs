using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00200
    {
        public string Callnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public string Srvstat { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public string Svcdescr { get; set; } = null!;
        public short PriorityLevel { get; set; }
        public string Custnmbr { get; set; } = null!;
        public string CustomerReference { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zip { get; set; } = null!;
        public string Cntcprsn { get; set; } = null!;
        public string Phone1 { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Svcarea { get; set; } = null!;
        public string Techid { get; set; } = null!;
        public string Timezone { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime NotifyDate { get; set; }
        public DateTime NotifyTime { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Dispdte { get; set; }
        public DateTime Disptme { get; set; }
        public DateTime Arrivdte { get; set; }
        public DateTime Arrivtme { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime ResponseTime { get; set; }
        public string Pricelvl { get; set; } = null!;
        public string Pymtrmid { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public decimal Labstotprc { get; set; }
        public decimal Labpct { get; set; }
        public decimal Labstotcst { get; set; }
        public decimal Parstotprc { get; set; }
        public decimal Partpct { get; set; }
        public decimal Parstotcst { get; set; }
        public decimal Mscstotprc { get; set; }
        public decimal Miscpct { get; set; }
        public decimal Misstotcst { get; set; }
        public string Taxschid { get; set; } = null!;
        public string Taxexmt1 { get; set; } = null!;
        public string Taxexmt2 { get; set; } = null!;
        public decimal Pretaxtot { get; set; }
        public decimal Taxamnt { get; set; }
        public decimal Total { get; set; }
        public decimal InvoicedAmount { get; set; }
        public int Meter1 { get; set; }
        public int Meter2 { get; set; }
        public int Meter3 { get; set; }
        public string Pordnmbr { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public byte Notfyflag { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public short Mstrrectype { get; set; }
        public string Mstrcallnbr { get; set; } = null!;
        public DateTime Escdate { get; set; }
        public DateTime Esctime { get; set; }
        public int EscalationLevel { get; set; }
        public string Spltterms { get; set; } = null!;
        public byte Callback { get; set; }
        public string Projctid { get; set; } = null!;
        public string ProjectRef11 { get; set; } = null!;
        public string ProjectRef12 { get; set; } = null!;
        public string ProjectRef13 { get; set; } = null!;
        public string ProjectRef14 { get; set; } = null!;
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public decimal SvcContractLineSeq { get; set; }
        public decimal Ettr { get; set; }
        public byte SvcOnHold { get; set; }
        public byte PrintToWeb { get; set; }
        public int Meters1 { get; set; }
        public int Meters2 { get; set; }
        public int Meters3 { get; set; }
        public int Meters4 { get; set; }
        public int Meters5 { get; set; }
        public int MeterInternalUses1 { get; set; }
        public int MeterInternalUses2 { get; set; }
        public int MeterInternalUses3 { get; set; }
        public int MeterInternalUses4 { get; set; }
        public int MeterInternalUses5 { get; set; }
        public string BillToCustomer { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
        public string SvcBillToAddressCode { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public short Decplacs { get; set; }
        public DateTime Time1 { get; set; }
        public short Ratecalc { get; set; }
        public short Viewmode { get; set; }
        public short Ismctrx { get; set; }
        public DateTime Expndate { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public decimal Origmisstotcst { get; set; }
        public decimal Origmscstotprc { get; set; }
        public decimal Origlabsubtotcost { get; set; }
        public decimal Origlabstotprc { get; set; }
        public decimal Origparstotcst { get; set; }
        public decimal Origparstotprc { get; set; }
        public decimal Origpretaxtot { get; set; }
        public decimal Ortaxamt { get; set; }
        public decimal Origtotal { get; set; }
        public decimal OrigInvoicedAmount { get; set; }
        public string Address3 { get; set; } = null!;
        public string Country { get; set; } = null!;
        public byte SvcPre600 { get; set; }
        public string SvcFoId { get; set; } = null!;
        public byte Replaces1 { get; set; }
        public byte Replaces2 { get; set; }
        public byte Replaces3 { get; set; }
        public byte Replaces4 { get; set; }
        public byte Replaces5 { get; set; }
        public int DexRowId { get; set; }
    }
}
