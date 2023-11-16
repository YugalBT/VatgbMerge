using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05000
    {
        public string Retdocid { get; set; } = null!;
        public short ReturnRecordType { get; set; }
        public short RmaStatus { get; set; }
        public byte Received { get; set; }
        public short Retorig { get; set; }
        public string Retref { get; set; } = null!;
        public string Retstat { get; set; } = null!;
        public string Rettype { get; set; } = null!;
        public DateTime Entdte { get; set; }
        public DateTime Enttme { get; set; }
        public DateTime Etadte { get; set; }
        public DateTime Etatme { get; set; }
        public DateTime Retudate { get; set; }
        public DateTime ReturnTime { get; set; }
        public DateTime Compdte { get; set; }
        public DateTime Comptme { get; set; }
        public string Userid { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Rtrnname { get; set; } = null!;
        public string Retaddr1 { get; set; } = null!;
        public string Retaddr2 { get; set; } = null!;
        public string Retaddr3 { get; set; } = null!;
        public string Rtrncity { get; set; } = null!;
        public string SvcReturnState { get; set; } = null!;
        public string Rtrnzip { get; set; } = null!;
        public string ReturnCountry { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Contact { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string Address2 { get; set; } = null!;
        public string Address3 { get; set; } = null!;
        public string City { get; set; } = null!;
        public string State { get; set; } = null!;
        public string Zipcode { get; set; } = null!;
        public string Country { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Callnbr { get; set; } = null!;
        public short Srvrectype { get; set; }
        public int Eqpline { get; set; }
        public int Lnitmseq { get; set; }
        public string BillOfLading { get; set; } = null!;
        public string Shipmthd { get; set; } = null!;
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public int SopLineItemSequence { get; set; }
        public int Cmpntseq { get; set; }
        public string BillToCustomer { get; set; } = null!;
        public string SvcBillToAddressCode { get; set; } = null!;
        public DateTime CommitDate { get; set; }
        public DateTime CommitTime { get; set; }
        public string Userdef1 { get; set; } = null!;
        public string Userdef2 { get; set; } = null!;
        public string Usrdef03 { get; set; } = null!;
        public string Usrdef04 { get; set; } = null!;
        public string Usrdef05 { get; set; } = null!;
        public string Curncyid { get; set; } = null!;
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
        public string Cstponbr { get; set; } = null!;
        public string SvcRmaReasonCode { get; set; } = null!;
        public string SvcRmaReasonCodeDesc { get; set; } = null!;
        public byte SvcRmaFromService { get; set; }
        public string SvcFoId { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
