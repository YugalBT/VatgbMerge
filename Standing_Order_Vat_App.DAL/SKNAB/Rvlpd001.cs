using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Rvlpd001
    {
        public short Keynumbr { get; set; }
        public byte EnablePmntDocRm { get; set; }
        public byte EnablePmntDocPm { get; set; }
        public int DexRowId { get; set; }
    }
}
