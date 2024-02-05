using pa1.TradepaDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class User
    {
        public string Username { get; set; } = null;

        public string Password { get; set; } = null;

        public int RoleID { get; set; }

        public virtual Role Role { get; set; } = null;
    }
}
