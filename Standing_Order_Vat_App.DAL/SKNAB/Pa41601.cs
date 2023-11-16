using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pa41601
    {
        public string Pactid { get; set; } = null!;
        public string Paptid { get; set; } = null!;
        public string Paptn { get; set; } = null!;
        public string Paprojnumseg { get; set; } = null!;
        public string Paprjclsid { get; set; } = null!;
        public short PaprojectType { get; set; }
        public short PaacctgMethod { get; set; }
        public short Pastat { get; set; }
        public string Padepartment { get; set; } = null!;
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
        public string PaestimatorId { get; set; } = null!;
        public string Paprojmngrid { get; set; } = null!;
        public string PabusMgrId { get; set; } = null!;
        public string Locatnid { get; set; } = null!;
        public short Comprcnt { get; set; }
        public short Comappto { get; set; }
        public string PalaborRateTableId { get; set; } = null!;
        public short PalaborRateTableType { get; set; }
        public byte PalaborRateTableAcc { get; set; }
        public string PaequipRateTableId { get; set; } = null!;
        public byte PaequipRateTableAcc { get; set; }
        public short Pabllngtype { get; set; }
        public decimal PaprojectAmount { get; set; }
        public decimal PaprojectFeeAmount { get; set; }
        public decimal PaserviceFeeAmount { get; set; }
        public decimal ParetainerFeeAmount { get; set; }
        public decimal ParetentionFeeAmount { get; set; }
        public decimal Acctamnt { get; set; }
        public string Pabillformat { get; set; } = null!;
        public short PadiscMetToUse { get; set; }
        public decimal Discamnt { get; set; }
        public short Dscpctam { get; set; }
        public decimal PaRetentionPercent { get; set; }
        public byte Patotcbts { get; set; }
        public byte PatotcbEl { get; set; }
        public byte PatotcbMl { get; set; }
        public byte Patotcbvi { get; set; }
        public byte Patotcber { get; set; }
        public byte Patotcbinv { get; set; }
        public byte Patotcbfee { get; set; }
        public string Paud1proj { get; set; } = null!;
        public string Paud2Proj { get; set; } = null!;
        public byte PasegmentCb { get; set; }
        public decimal Pabillnoteidx { get; set; }
        public decimal Pabillnoteidxts { get; set; }
        public decimal Paelbillniteidx { get; set; }
        public decimal PabillnoteidxMl { get; set; }
        public decimal Pabillnoteidxvi { get; set; }
        public decimal Pabillnoteidxee { get; set; }
        public decimal Pabillnoteidxinv { get; set; }
        public decimal Pabillnoteidxfee { get; set; }
        public decimal Noteindx { get; set; }
        public string Wrkrcomp { get; set; } = null!;
        public string Sutastat { get; set; } = null!;
        public int DexRowId { get; set; }
    }
}
