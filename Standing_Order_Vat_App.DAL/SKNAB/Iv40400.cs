using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv40400
    {
        public string Itmclscd { get; set; } = null!;
        public string Itmclsdc { get; set; } = null!;
        public byte Defltcls { get; set; }
        public decimal Noteindx { get; set; }
        public short Itemtype { get; set; }
        public short Itmtrkop { get; set; }
        public string Lottype { get; set; } = null!;
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kpdsthst { get; set; }
        public byte Alwbkord { get; set; }
        public string Itmgedsc { get; set; } = null!;
        public short Taxoptns { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short PurchaseTaxOptions { get; set; }
        public string PurchaseItemTaxSchedu { get; set; } = null!;
        public string Uomschdl { get; set; } = null!;
        public short Vctnmthd { get; set; }
        public string Uscatvls1 { get; set; } = null!;
        public string Uscatvls2 { get; set; } = null!;
        public string Uscatvls3 { get; set; } = null!;
        public string Uscatvls4 { get; set; } = null!;
        public string Uscatvls5 { get; set; } = null!;
        public string Uscatvls6 { get; set; } = null!;
        public short Decplqty { get; set; }
        public int Ivivindx { get; set; }
        public int Ivivofix { get; set; }
        public int Ivcogsix { get; set; }
        public int Ivslsidx { get; set; }
        public int Ivsldsix { get; set; }
        public int Ivslrnix { get; set; }
        public int Ivinusix { get; set; }
        public int Ivinsvix { get; set; }
        public int Ivdmgidx { get; set; }
        public int Ivvaridx { get; set; }
        public int Dpshpidx { get; set; }
        public int Purpvidx { get; set; }
        public int Uppvidx { get; set; }
        public int Ivretidx { get; set; }
        public int Asmvridx { get; set; }
        public string Prclevel { get; set; } = null!;
        public string PriceGroup { get; set; } = null!;
        public short Pricmthd { get; set; }
        public string Tcc { get; set; } = null!;
        public byte RevalueInventory { get; set; }
        public int TolerancePercentage { get; set; }
        public string Cntryorgn { get; set; } = null!;
        public short Sttstclvlprcntg { get; set; }
        public byte Includeindp { get; set; }
        public int DexRowId { get; set; }
    }
}
