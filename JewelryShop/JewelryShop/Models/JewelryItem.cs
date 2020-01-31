using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Models
{
    public class JewelryItem
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool InStock { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public string Price { get; set; }
    }
}
