using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.GeneralResult
{
    public class GeneralResult<T> : IGeneralResult<T>
    {
        public bool Successful { get; set; }
        public string Message { get; set; }
        public T Value { get; set; }
    }
    public interface IGeneralResult<T>
    {
        bool Successful { get; set; }
        string ? Message { get; set; } 
        T Value { get; set; }
    }
}
