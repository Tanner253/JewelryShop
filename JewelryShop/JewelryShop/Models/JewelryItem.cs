using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Models
{
    public class JewelryItem
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string InStock { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name = "Picture One")]
        public string Picture1 { get; set; }
        [Display(Name = "Picture Two")]
        public string Picture2 { get; set; }
        [Display(Name = "Picture Three")]
        public string Picture3 { get; set; }
        [Required]
        public string Price { get; set; }
    }
}
