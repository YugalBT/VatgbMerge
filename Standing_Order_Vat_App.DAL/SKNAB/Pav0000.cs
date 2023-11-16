using System;
using System.Collections.Generic;

namespace Standing_Order_Vat_App.DAL.SKNAB
{
    public partial class Pav0000
    {
        public string Paprojnumber { get; set; } = null!;
        public string Paprojid { get; set; } = null!;
        public string Paprojname { get; set; } = null!;
        public string Pacontnumber { get; set; } = null!;
        public string Paprjclsid { get; set; } = null!;
        public string Custnmbr { get; set; } = null!;
        public string Paprojmngrid { get; set; } = null!;
        public string Pacontclassid { get; set; } = null!;
        public string Pacontid { get; set; } = null!;
        public string Pacontname { get; set; } = null!;
        public string Slprsnid { get; set; } = null!;
        public string Salsterr { get; set; } = null!;
        public string Custname { get; set; } = null!;
        public string Custclas { get; set; } = null!;
        public short PaprojectType { get; set; }
    }
}
