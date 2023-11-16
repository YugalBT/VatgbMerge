using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc00602
    {
        public string Cnttype { get; set; } = null!;
        public string Cnttypdesc { get; set; } = null!;
        public string Srvtype { get; set; } = null!;
        public int GlPrepaidAccount { get; set; }
        public int GlServiceAccount { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public byte Usecvpd1 { get; set; }
        public byte Usecvpd2 { get; set; }
        public byte Usecvpd3 { get; set; }
        public byte Usecvpd4 { get; set; }
        public byte Usecvpd5 { get; set; }
        public byte Usecvpd6 { get; set; }
        public byte Usecvpd7 { get; set; }
        public DateTime ContractCoveragePeriod1 { get; set; }
        public DateTime ContractCoveragePeriod2 { get; set; }
        public DateTime ContractCoveragePeriod3 { get; set; }
        public DateTime ContractCoveragePeriod4 { get; set; }
        public DateTime ContractCoveragePeriod5 { get; set; }
        public DateTime ContractCoveragePeriod6 { get; set; }
        public DateTime ContractCoveragePeriod7 { get; set; }
        public DateTime Cntcovpd1 { get; set; }
        public DateTime Cntcovpd2 { get; set; }
        public DateTime Cntcovpd3 { get; set; }
        public DateTime Cntcovpd4 { get; set; }
        public DateTime Cntcovpd5 { get; set; }
        public DateTime Cntcovpd6 { get; set; }
        public DateTime Cntcovpd7 { get; set; }
        public short GraceDays { get; set; }
        public int MeterBases1 { get; set; }
        public int MeterBases2 { get; set; }
        public int MeterBases3 { get; set; }
        public int MeterBases4 { get; set; }
        public int MeterBases5 { get; set; }
        public int MeterOverages1 { get; set; }
        public int MeterOverages2 { get; set; }
        public int MeterOverages3 { get; set; }
        public int MeterOverages4 { get; set; }
        public int MeterOverages5 { get; set; }
        public int MeterOverages6 { get; set; }
        public int MeterOverages7 { get; set; }
        public int MeterOverages8 { get; set; }
        public int MeterOverages9 { get; set; }
        public int MeterOverages10 { get; set; }
        public int MeterOverages11 { get; set; }
        public int MeterOverages12 { get; set; }
        public int MeterOverages13 { get; set; }
        public int MeterOverages14 { get; set; }
        public int MeterOverages15 { get; set; }
        public int MeterOverages16 { get; set; }
        public int MeterOverages17 { get; set; }
        public int MeterOverages18 { get; set; }
        public int MeterOverages19 { get; set; }
        public int MeterOverages20 { get; set; }
        public decimal MeterCharges1 { get; set; }
        public decimal MeterCharges2 { get; set; }
        public decimal MeterCharges3 { get; set; }
        public decimal MeterCharges4 { get; set; }
        public decimal MeterCharges5 { get; set; }
        public decimal MeterCharges6 { get; set; }
        public decimal MeterCharges7 { get; set; }
        public decimal MeterCharges8 { get; set; }
        public decimal MeterCharges9 { get; set; }
        public decimal MeterCharges10 { get; set; }
        public decimal MeterCharges11 { get; set; }
        public decimal MeterCharges12 { get; set; }
        public decimal MeterCharges13 { get; set; }
        public decimal MeterCharges14 { get; set; }
        public decimal MeterCharges15 { get; set; }
        public decimal MeterCharges16 { get; set; }
        public decimal MeterCharges17 { get; set; }
        public decimal MeterCharges18 { get; set; }
        public decimal MeterCharges19 { get; set; }
        public decimal MeterCharges20 { get; set; }
        public byte MeterExpires1 { get; set; }
        public byte MeterExpires2 { get; set; }
        public byte MeterExpires3 { get; set; }
        public byte MeterExpires4 { get; set; }
        public byte MeterExpires5 { get; set; }
        public byte SvcInvoiceDetail { get; set; }
        public byte Prepaid { get; set; }
        public string SvcContractBatchId { get; set; } = null!;
        public string SvcContractDocumentId { get; set; } = null!;
        public string ContractResponseTime { get; set; } = null!;
        public byte SvcDiscountFlag { get; set; }
        public int SvcDiscountAccount { get; set; }
        public string SvcCCreditBatchId { get; set; } = null!;
        public string SvcCCreditDocumentId { get; set; } = null!;
        public short PriorityLevel { get; set; }
        public int DexRowId { get; set; }
    }
}
