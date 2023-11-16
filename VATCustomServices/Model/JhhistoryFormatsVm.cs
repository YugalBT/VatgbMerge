using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATCustomServices.Model
{
    public class JhhistoryFormatsVm
    {
        public string Code { get; set; } = null!;
        public int FieldLength { get; set; }
        public string Description { get; set; } = null!;
        public int? FieldStartPosition { get; set; }
    }
}
