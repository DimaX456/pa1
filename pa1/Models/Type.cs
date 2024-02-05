using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pa1.Models
{
    public partial class Type
    {
        public Type()
        {
            Perfumes = new HashSet<Perfume>(); 
        }
        public string ID { get; set; } = null;
        public string Name { get; set; } = null;
        public string Description { get; set; }
        public virtual ICollection<Perfume> Perfumes { get;set; }
    }
}
