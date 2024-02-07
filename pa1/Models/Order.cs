using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public int OrderId { get; set; }
        public string TheOrder { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime OrderDeliveryDate { get; set; }
        public int OrderPickupPoint { get; set; }
        public string FioClient { get; set; }
        public string CodeGive { get; set; }
        public bool OrderStatus { get; set; }
        public int CountOrder { get; set; }

        public virtual PickupPoint OrderPickupPointNavigation { get; set; }
        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
