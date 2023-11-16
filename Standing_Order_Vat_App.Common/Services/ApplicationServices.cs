using Standing_Order_Vat_App.Common.Interfaces;
using Standing_Order_Vat_App.DAL.Directory_DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.Common.Services
{
    public class ApplicationServices : IApplication
    {
        private readonly DirectoryContext dirdbcontext;
        public ApplicationServices(DirectoryContext dirdbcontext)
        {
            this.dirdbcontext = dirdbcontext;
        }
        public Application CreateApplication(Application model)
        {
            dirdbcontext.Applications.Add(model);
            dirdbcontext.SaveChanges();
            return model;
        }
    }
}
