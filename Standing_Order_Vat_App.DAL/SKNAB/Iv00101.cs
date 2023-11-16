using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Iv00101
    {
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public decimal Noteindx { get; set; }
        public string Itmshnam { get; set; } = null!;
        public short Itemtype { get; set; }
        public string Itmgedsc { get; set; } = null!;
        public decimal Stndcost { get; set; }
        public decimal Currcost { get; set; }
        public int Itemshwt { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public string Itmtshid { get; set; } = null!;
        public short Taxoptns { get; set; }
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
        public string Itmclscd { get; set; } = null!;
        public short Itmtrkop { get; set; }
        public string Lottype { get; set; } = null!;
        public byte Kperhist { get; set; }
        public byte Kptrxhst { get; set; }
        public byte Kpcalhst { get; set; }
        public byte Kpdsthst { get; set; }
        public byte Alwbkord { get; set; }
        public short Vctnmthd { get; set; }
        public string Uomschdl { get; set; } = null!;
        public string Altitem1 { get; set; } = null!;
        public string Altitem2 { get; set; } = null!;
        public string Uscatvls1 { get; set; } = null!;
        public string Uscatvls2 { get; set; } = null!;
        public string Uscatvls3 { get; set; } = null!;
        public string Uscatvls4 { get; set; } = null!;
        public string Uscatvls5 { get; set; } = null!;
        public string Uscatvls6 { get; set; } = null!;
        public short Mstrcdty { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public short Wrntydys { get; set; }
        public string Prclevel { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public int Pinflidx { get; set; }
        public int Purmcidx { get; set; }
        public int Ivinfidx { get; set; }
        public int Invmcidx { get; set; }
        public int Cgsinflx { get; set; }
        public int Cgsmcidx { get; set; }
        public string Itemcode { get; set; } = null!;
        public string Tcc { get; set; } = null!;
        public string PriceGroup { get; set; } = null!;
        public short Pricmthd { get; set; }
        public string Prchsuom { get; set; } = null!;
        public string Selnguom { get; set; } = null!;
        public short Ktacctsr { get; set; }
        public string Lastgensn { get; set; } = null!;
        public short Abccode { get; set; }
        public byte RevalueInventory { get; set; }
        public int TolerancePercentage { get; set; }
        public string PurchaseItemTaxSchedu { get; set; } = null!;
        public short PurchaseTaxOptions { get; set; }
        public short Itmplnnngtyp { get; set; }
        public short Sttstclvlprcntg { get; set; }
        public string Cntryorgn { get; set; } = null!;
        public byte Inactive { get; set; }
        public short Minshelf1 { get; set; }
        public short Minshelf2 { get; set; }
        public byte Includeindp { get; set; }
        public int DexRowId { get; set; }
    }
}
