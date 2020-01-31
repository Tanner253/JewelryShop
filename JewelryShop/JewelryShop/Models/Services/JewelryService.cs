using JewelryShop.Data;
using JewelryShop.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JewelryShop.Models.Services
{
    public class JewelryService : IJewelry
    {

        private ShopDbContext _context;

        public JewelryService(ShopDbContext context)
        {
            _context = context;
        }
        public async Task CreateItem(JewelryItem item)
        {
            _context.Add(item);
            await _context.SaveChangesAsync();
        }

        public async Task<JewelryItem> DeleteItem(int id)
        {
            JewelryItem item = await _context.JewelryItem.FirstOrDefaultAsync(m => m.ID == id);
            return item;
        }

        public async Task DeleteItemFR(int id)
        {
            var item = await _context.JewelryItem.FindAsync(id);
            _context.JewelryItem.Remove(item);
            await _context.SaveChangesAsync();
        }

        public async Task<JewelryItem> GetItem(int id)
        {
            var item = await _context.JewelryItem.FirstOrDefaultAsync(m => m.ID == id);
            return item;
        }

        public async Task<IEnumerable<JewelryItem>> GetItems()
        {
            var item = await _context.JewelryItem.ToListAsync();
            return item;
        }

        public bool ItemExists(int id)
        {
            return _context.JewelryItem.Any(m => m.ID == id);
        }

        public async Task UpdateItem(int id, [Bind("ID,Name,Price")]JewelryItem item)
        {
            _context.Update(item);
            await _context.SaveChangesAsync();
        }
    }
}
