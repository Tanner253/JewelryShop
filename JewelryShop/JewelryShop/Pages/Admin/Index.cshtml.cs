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
    public class IndexModel : PageModel
    {
        private readonly JewelryShop.Data.ShopDbContext _context;

        public IndexModel(JewelryShop.Data.ShopDbContext context)
        {
            _context = context;
        }

        public IList<JewelryItem> JewelryItem { get;set; }

        public async Task OnGetAsync()
        {
            JewelryItem = await _context.JewelryItem.ToListAsync();
        }
    }
}
