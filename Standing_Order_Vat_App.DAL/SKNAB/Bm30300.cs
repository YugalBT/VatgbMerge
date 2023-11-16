using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Bm30300
    {
        public string TrxId { get; set; } = null!;
        public int ComponentId { get; set; }
        public int ParentComponentId { get; set; }
        public string Itemnmbr { get; set; } = null!;
        public string Itemdesc { get; set; } = null!;
        public string Uofm { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public decimal LocationCodeNoteIndex { get; set; }
        public decimal StockQuantity { get; set; }
        public decimal AssembleQuantity { get; set; }
        public short BmStockMethod { get; set; }
        public short CostType { get; set; }
        public int Invindx { get; set; }
        public string InventoryAccountReference { get; set; } = null!;
        public int VarianceIndex { get; set; }
        public string VarianceAccountReference { get; set; } = null!;
        public decimal DesignQuantity { get; set; }
        public short ScrapPercentage { get; set; }
        public decimal Stndcost { get; set; }
        public decimal StandardQuantity { get; set; }
        public decimal ExtendedStandardCost { get; set; }
        public decimal ExtendedStandardQuantity { get; set; }
        public decimal ExtAssembleQtyPostingCost { get; set; }
        public decimal ExtStockReceiptCost { get; set; }
        public decimal ExtStockQtyPostingCost { get; set; }
        public decimal ExtSubasmPostingCost { get; set; }
        public decimal ExtSubasmReceiptCost { get; set; }
        public short BmComponentType { get; set; }
        public short Lvl { get; set; }
        public decimal Qtybsuom { get; set; }
        public decimal AssembleSerialLotCount { get; set; }
        public decimal StockSerialLotCount { get; set; }
        public short Decplqty { get; set; }
        public short Decplcur { get; set; }
        public short Itmtrkop { get; set; }
        public decimal Noteindx { get; set; }
        public decimal InventoryAccountNoteI { get; set; }
        public decimal VarianceAccountNoteIn { get; set; }
        public byte[] BmComponentErrors { get; set; } = null!;
        public string Trxsorce { get; set; } = null!;
        public string Bin { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
