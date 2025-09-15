using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MvcProduct.Infrastructure.Data;
using MvcProduct.UserInterface.Models;

namespace MvcProduct.UserInterface.Controllers
{
    public class FishsController : Controller
    {
        private readonly MvcFishContext _context;

        public FishsController(MvcFishContext context)
        {
            _context = context;
        }

        // GET: Fishs
        public async Task<IActionResult> Index()
        {
            return View("~/UserInterface/Views/Fishs/Index.cshtml", await _context.Fishs.ToListAsync());
        }

        // GET: Fishs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishs = await _context.Fishs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishs == null)
            {
                return NotFound();
            }

            return View("~/UserInterface/Views/Fishs/Details.cshtml", fishs);
        } 


        // GET: Fishs/Create
        public IActionResult Create()
        {
            return View("~/UserInterface/Views/Fishs/Create.cshtml");
        }

        // POST: Fishs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Fish,CaughtDate,WaterType,Age,Price")] Fishs fishs)
        {
            if (ModelState.IsValid)
            {
                _context.Add(fishs);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View("~/UserInterface/Views/Fishs/Create.cshtml", fishs);
        }

        // GET: Fishs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishs = await _context.Fishs.FindAsync(id);
            if (fishs == null)
            {
                return NotFound();
            }
            return View("~/UserInterface/Views/Fishs/Edit.cshtml", fishs);
        }

        // POST: Fishs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Fish,CaughtDate,WaterType,Age,Price")] Fishs fishs)
        {
            if (id != fishs.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(fishs);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FishsExists(fishs.Id))
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
            return View("~/UserInterface/Views/Fishs/Edit.cshtml", fishs);
        }

        // GET: Fishs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var fishs = await _context.Fishs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (fishs == null)
            {
                return NotFound();
            }

            return View("~/UserInterface/Views/Fishs/Delete.cshtml", fishs);
        }

        // POST: Fishs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var fishs = await _context.Fishs.FindAsync(id);
            if (fishs != null)
            {
                _context.Fishs.Remove(fishs);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FishsExists(int id)
        {
            return _context.Fishs.Any(e => e.Id == id);
        }
    }
}
