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
        public string InStock { get; set; }
        public string Description { get; set; }
        public string Picture1 { get; set; }
        public string Picture2 { get; set; }
        public string Picture3 { get; set; }
        public string Price { get; set; }
    }
}
