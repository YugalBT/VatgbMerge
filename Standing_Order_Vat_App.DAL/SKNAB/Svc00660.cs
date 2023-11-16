using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00660
    {
        public short Soptype { get; set; }
        public string Sopnumbe { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Cnttype { get; set; } = null!;
        public short ContractLength { get; set; }
        public short ContractPeriod { get; set; }
        public DateTime Strtdate { get; set; }
        public DateTime Enddate { get; set; }
        public byte Prepaid { get; set; }
        public string Pricshed { get; set; } = null!;
        public short Billngth { get; set; }
        public short Bilprd { get; set; }
        public DateTime Bilstrt { get; set; }
        public DateTime Bilend { get; set; }
        public short Bilondy { get; set; }
        public short Bilcyc { get; set; }
        public short SvcLiabilityType { get; set; }
        public string BillToCustomer { get; set; } = null!;
        public string SvcBillToAddressCode { get; set; } = null!;
        public string Pordnmbr { get; set; } = null!;
        public byte SvcInvoiceDetail { get; set; }
        public decimal Partpct { get; set; }
        public decimal Labpct { get; set; }
        public decimal Miscpct { get; set; }
        public decimal Pmprtpct { get; set; }
        public decimal Pmlabpct { get; set; }
        public decimal Pmmscpct { get; set; }
        public byte SvcPaidContract { get; set; }
        public short Dscpctam { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Currnidx { get; set; }
        public string Ratetpid { get; set; } = null!;
        public string Exgtblid { get; set; } = null!;
        public decimal Xchgrate { get; set; }
        public DateTime Exchdate { get; set; }
        public DateTime Time1 { get; set; }
        public decimal Denxrate { get; set; }
        public short Mctrxstt { get; set; }
        public int DexRowId { get; set; }
    }
}
