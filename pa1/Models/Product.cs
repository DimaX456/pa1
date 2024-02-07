using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class Product
    {
        public Product()
        {
            OrderProduct = new HashSet<OrderProduct>();
        }

        public string ProductArticleNumber { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductCategory { get; set; }
        public byte[] ProductPhoto { get; set; }
        public string ProductManufacturer { get; set; }
        public decimal ProductCost { get; set; }
        public decimal? ProductDiscountAmount { get; set; }
        public int ProductQuantityInStock { get; set; }
        public bool ProductStatus { get; set; }

        public virtual ICollection<OrderProduct> OrderProduct { get; set; }
    }
}
