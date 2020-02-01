using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop
{
    public class DetailsModel : PageModel
    {
        private readonly JewelryShop.Data.ShopDbContext _context;

        public DetailsModel(JewelryShop.Data.ShopDbContext context)
        {
            _context = context;
        }

        public JewelryItem JewelryItem { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            JewelryItem = await _context.JewelryItem.FirstOrDefaultAsync(m => m.ID == id);

            if (JewelryItem == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
