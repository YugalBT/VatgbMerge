using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svc05635
    {
        public string Userid { get; set; } = null!;
        public string RtvNumber { get; set; } = null!;
        public decimal RtvLine { get; set; }
        public string RtvType { get; set; } = null!;
        public string Offid { get; set; } = null!;
        public string Vendorid { get; set; } = null!;
        public string Adrscode { get; set; } = null!;
        public string Vendname { get; set; } = null!;
        public string Locncode { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Vnditnum { get; set; } = null!;
        public decimal PartCost { get; set; }
        public decimal PartPrice { get; set; }
        public decimal LaborCost { get; set; }
        public decimal LaborPrice { get; set; }
        public decimal ExpenseCost { get; set; }
        public decimal ExpensePrice { get; set; }
        public decimal TravelCost { get; set; }
        public decimal TravelPrice { get; set; }
        public decimal OriginatingPartCost { get; set; }
        public decimal OriginatingPartPrice { get; set; }
        public decimal OriginatingLaborCost { get; set; }
        public decimal OriginatingLaborPrice { get; set; }
        public decimal OriginatingExpenseCost { get; set; }
        public decimal OriginatingExpensePrice { get; set; }
        public decimal OriginatingTravelCost { get; set; }
        public decimal OriginatingTravelPrice { get; set; }
        public byte Mkdtopst { get; set; }
        public byte Posted { get; set; }
        public short Ermsgnbr { get; set; }
        public string Ermsgtxt { get; set; } = null!;
        public string Ermsgtx2 { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
