using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Standing_Order_Vat_App.DAL.Directory_DB
{
    public  class UserPermission
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }

        public virtual User? User { get; set; }
    }
}
