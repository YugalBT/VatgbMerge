using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Svcsocov
    {
        public short Consts { get; set; }
        public string Contnbr { get; set; } = null!;
        public string Itemnmbr { get; set; } = null!;
        public string Serlnmbr { get; set; } = null!;
        public short? Srvrectype { get; set; }
        public string? Callnbr { get; set; }
        public string? Srvtype { get; set; }
        public string? Svcdescr { get; set; }
        public string? Adrscode { get; set; }
        public string? Offid { get; set; }
        public string? Svcarea { get; set; }
        public string? Techid { get; set; }
        public DateTime? Entdte { get; set; }
        public DateTime? Enttme { get; set; }
        public DateTime? Dispdte { get; set; }
        public DateTime? Disptme { get; set; }
        public DateTime? Etadte { get; set; }
        public DateTime? Etatme { get; set; }
        public DateTime? Arrivdte { get; set; }
        public DateTime? Arrivtme { get; set; }
        public DateTime? Compdte { get; set; }
        public DateTime? Comptme { get; set; }
        public decimal? Labstotprc { get; set; }
        public decimal? Labpct { get; set; }
        public decimal? Labstotcst { get; set; }
        public decimal? Parstotprc { get; set; }
        public decimal? Partpct { get; set; }
        public decimal? Parstotcst { get; set; }
        public decimal? Mscstotprc { get; set; }
        public decimal? Miscpct { get; set; }
        public decimal? Misstotcst { get; set; }
        public decimal? Pretaxtot { get; set; }
        public decimal? Taxamnt { get; set; }
        public decimal? Total { get; set; }
        public decimal? InvoicedAmount { get; set; }
        public int? DexRowId { get; set; }
    }
}
