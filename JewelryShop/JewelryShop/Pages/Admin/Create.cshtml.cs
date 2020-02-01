using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using JewelryShop.Data;
using JewelryShop.Models;

namespace JewelryShop
{
    public class CreateModel : PageModel
    {
        private readonly JewelryShop.Data.ShopDbContext _context;

        public CreateModel(JewelryShop.Data.ShopDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public JewelryItem JewelryItem { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.JewelryItem.Add(JewelryItem);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}