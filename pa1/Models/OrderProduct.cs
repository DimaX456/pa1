using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class OrderProduct
    {
        public int OrderId { get; set; }
        public string ProductArticleNumber { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product ProductArticleNumberNavigation { get; set; }
    }
}
