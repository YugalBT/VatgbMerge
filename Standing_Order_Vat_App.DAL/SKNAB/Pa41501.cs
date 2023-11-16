using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41501
    {
        public string Pactid { get; set; } = null!;
        public string Pactn { get; set; } = null!;
        public string Palongid1 { get; set; } = null!;
        public string Palongid2 { get; set; } = null!;
        public string Palongid3 { get; set; } = null!;
        public string Palongid4 { get; set; } = null!;
        public string Palongid5 { get; set; } = null!;
        public string Pacontclassid { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public string PacontMgrId { get; set; } = null!;
        public string PabusMgrId { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public short Comappto { get; set; }
        public string Pabillformat { get; set; } = null!;
        public DateTime PabbeginDate { get; set; }
        public DateTime PabendDate { get; set; }
        public decimal Pabquantity { get; set; }
        public decimal PabtotalCost { get; set; }
        public decimal Pabprofit { get; set; }
        public decimal Pabbillings { get; set; }
        public decimal PabtaxPaidAmt { get; set; }
        public decimal PabtaxChargedAmt { get; set; }
        public decimal PabaselineOvhdCost { get; set; }
        public DateTime PafbeginDate { get; set; }
        public DateTime PafendDate { get; set; }
        public decimal Pafquantity { get; set; }
        public decimal PaftotalCost { get; set; }
        public decimal Pafprofit { get; set; }
        public decimal Pafbillings { get; set; }
        public decimal PaftaxPaidAmt { get; set; }
        public decimal PaftaxChargedAmt { get; set; }
        public decimal PaforecastOvhdCost { get; set; }
        public string Paud1Cont { get; set; } = null!;
        public string Paud2Cont { get; set; } = null!;
        public byte PasegmentCb { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal PaprojectFeeAmount { get; set; }
        public decimal PaserviceFeeAmount { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Pabillnoteidxts { get; set; }
        public decimal Paelbillniteidx { get; set; }
        public decimal PabillnoteidxMl { get; set; }
        public decimal Pabillnoteidxvi { get; set; }
        public decimal Pabillnoteidxee { get; set; }
        public decimal Pabillnoteidxinv { get; set; }
        public decimal Pabillnoteidxfee { get; set; }
        public decimal Noteindx { get; set; }
        public int DexRowId { get; set; }
    }
}
