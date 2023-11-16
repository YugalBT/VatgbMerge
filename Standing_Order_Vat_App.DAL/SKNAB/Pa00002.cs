using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa00002
    {
        public short Index1 { get; set; }
        public string PaNextDocumentNumber { get; set; } = null!;
        public int Actindx { get; set; }
        public byte PaAutoCreateVendors { get; set; }
        public byte PaAutoCreateCustomerVend { get; set; }
        public short PaCreateVendorType { get; set; }
        public string PaDefaultVendorClass { get; set; } = null!;
        public string PaNextVendorId { get; set; } = null!;
        public string PaDebitDescriptionPrefix { get; set; } = null!;
        public string PaVoucherDescrPrefix { get; set; } = null!;
        public byte PaAutoOpenSelectChecks { get; set; }
        public byte PaIntegrateEft { get; set; }
        public short PaCreateCustomerType { get; set; }
        public string PaDefaultCustomerClass { get; set; } = null!;
        public string PaNextCustomerId { get; set; } = null!;
        public string PaPmprefix { get; set; } = null!;
        public string PaPmnextDocument { get; set; } = null!;
        public string PaRmprefix { get; set; } = null!;
        public int PaConsolidationIndex { get; set; }
        public byte Crtmpvnd { get; set; }
        public int DexRowId { get; set; }
    }
}
