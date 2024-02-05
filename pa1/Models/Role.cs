using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class Role
    {
        public Role()
        {
            Users = new HashSet<User>();
        }
        public int IDRole { get; set;  }
        public string NameRole { get; set; } = null;
        public virtual ICollection<User> Users { get; set; }
    }
}
