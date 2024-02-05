using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class Perfume
    {
        public Perfume()
        {
            Types = new HashSet<Type>();
        }
        public string ID { get; set; } = null;
        public string Name { get; set; } = null;
        public byte[] ImagePreview { get; set; }
        public decimal Price { get; set; }
        public bool IsActual { get; set; }
        public int Count { get; set; }
        public virtual ICollection<Type> Types { get; set; }
    }
}
