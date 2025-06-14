using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory.models
{
    public class Currency
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; } // Changed from private to public  
        public ICollection<Branch> Branches { get; set; } // Changed from private to public  
    }
}
