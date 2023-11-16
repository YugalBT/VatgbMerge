using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Hr2ben17
    {
        public int BeneficiaryindexI { get; set; }
        public string BeneficiaryprimaryI { get; set; } = null!;
        public string BencontingentI { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
