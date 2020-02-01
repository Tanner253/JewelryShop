using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JewelryShop.Data;
using JewelryShop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JewelryShop.Controllers
{
    public class ShopController : Controller
    {
        private readonly ShopDbContext _context;
        public ShopController(ShopDbContext context)
        {
            _context = context;
        }
        // GET: Shop
        public ViewResult Index(string searchString)
        {
            var item = from s in _context.JewelryItem
                       select s;


            if (!String.IsNullOrEmpty(searchString))
            {
                item = item.Where(s => s.Name.Contains(searchString));
            }


            return View(item.ToList());
        }

        // GET: Shop/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var item = await _context.JewelryItem.FirstOrDefaultAsync(m => m.ID == id);

            if (item == null)
            {
                return NotFound();
            }
            return View();
        }

        // GET: Shop/Create
        public IActionResult Create()
        {

            return View();
        }

        // POST: Shop/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Name,Description,InStock,Picture1,Picture2,Picture3")] JewelryItem item)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(item);
                    await _context.SaveChangesAsync();
                }
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View(item);

            }
        }

        // GET: Shop/Edit/5
        public ActionResult Edit(int? id)
        {
            return View();
        }

        // POST: Shop/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Name,Description,InStock,Picture1,Picture2,Picture3")] JewelryItem item)
        {
            if (id != item.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(item);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(item.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(item);

        }

        // GET: Shop/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var item = await _context.JewelryItem.FirstOrDefaultAsync(m => m.ID == id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        // POST: Shop/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteFR(int id)
        {
            try
            {
                var item = await _context.JewelryItem.FindAsync(id);
                _context.JewelryItem.Remove(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }
            catch
            {
                return View();
            }
        }
        private bool ItemExists(int id)
        {
            return _context.JewelryItem.Any(e => e.ID == id);
        }
    }
}