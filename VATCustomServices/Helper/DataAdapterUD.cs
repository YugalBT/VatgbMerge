using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VATCustomServices.Helper
{
    public static class DataAdapterUD
    {
        public static DbDataAdapter CreateDataAdapter(this DbConnection connection, DbCommand command)
        {
            var adp = DbProviderFactories.GetFactory(connection).CreateDataAdapter();
            adp.SelectCommand = command;
            return adp;
        }
    }
}
