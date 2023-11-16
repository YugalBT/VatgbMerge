using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Sy00500
    {
        public DateTime Glpostdt { get; set; }
        public string Bchsourc { get; set; } = null!;
        public string Bachnumb { get; set; } = null!;
        public short Series { get; set; }
        public byte Mkdtopst { get; set; }
        public int Numoftrx { get; set; }
        public short Recpstgs { get; set; }
        public byte Delbach { get; set; }
        public short Mscbdinc { get; set; }
        public short Bachfreq { get; set; }
        public DateTime Rclpstdt { get; set; }
        public short Nofpstgs { get; set; }
        public string Bchcomnt { get; set; } = null!;
        public byte Brkdnall { get; set; }
        public byte Chksprtd { get; set; }
        public byte Rvrsbach { get; set; }
        public string Userid { get; set; } = null!;
        public string Chekbkid { get; set; } = null!;
        public decimal Bchtotal { get; set; }
        public byte[] Bchemsg1 { get; set; } = null!;
        public byte[] Bchemsg2 { get; set; } = null!;
        public DateTime Bachdate { get; set; }
        public string Bchstrg1 { get; set; } = null!;
        public string Bchstrg2 { get; set; } = null!;
        public byte Posttogl { get; set; }
        public DateTime Modifdt { get; set; }
        public DateTime Creatddt { get; set; }
        public decimal Noteindx { get; set; }
        public string Curncyid { get; set; } = null!;
        public short Bchsttus { get; set; }
        public int Cntrltrx { get; set; }
        public decimal Cntrltot { get; set; }
        public short Petrxcnt { get; set; }
        public byte Approvl { get; set; }
        public DateTime Apprvldt { get; set; }
        public string Aprvluserid { get; set; } = null!;
        public short Origin { get; set; }
        public int Errstate { get; set; }
        public byte[] Glbchval { get; set; } = null!;
        public DateTime ComputerCheckDocDate { get; set; }
        public short SortChecksBy { get; set; }
        public byte Seprmtnc { get; set; }
        public short Reprnted { get; set; }
        public short Chkfrmts { get; set; }
        public string Trxsorce { get; set; } = null!;
        public short PmtMethod { get; set; }
        public short EftfileFormat { get; set; }
        public int DexRowId { get; set; }
    }
}
