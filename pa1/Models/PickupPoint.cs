using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class PickupPoint
    {
        public PickupPoint()
        {
            Order = new HashSet<Order>();
        }

        public int IdPickupPoint { get; set; }
        public string MailIndexPickupPoint { get; set; }
        public string CityPickupPoint { get; set; }
        public string StreetPickupPoint { get; set; }
        public string NumberHousePickupPoint { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
