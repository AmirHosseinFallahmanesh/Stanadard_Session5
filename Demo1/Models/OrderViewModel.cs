using System.Collections.Generic;

namespace Demo1.Models
{
    public class OrderViewModel
    {
        public string Name { get; set; }
        public List<OrderLine> Lines { get; set; }

        public List<Product> RecomProducts { get; set; }

        
    }
  
}