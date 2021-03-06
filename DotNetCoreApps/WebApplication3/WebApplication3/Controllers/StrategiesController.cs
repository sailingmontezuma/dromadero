﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication3.Data;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class StrategiesController : Controller
    {
        private readonly FxContext _context;

        public StrategiesController(FxContext context)
        {
            _context = context;
        }

        // GET: Strategies
        public async Task<IActionResult> Index()
        {
            var fxContext = _context.Strategies.Include(s => s.Symbol).Include(s => s.TradeType);
            return View(await fxContext.ToListAsync());
        }

        // GET: Strategies/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strategy = await _context.Strategies
                .Include(s => s.Symbol)
                .Include(s => s.TradeType)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (strategy == null)
            {
                return NotFound();
            }

            return View(strategy);
        }

        // GET: Strategies/Create
        public IActionResult Create()
        {
            ViewData["SymbolId"] = new SelectList(_context.Symbols, "Id", "Name");
            ViewData["TradeTypeId"] = new SelectList(_context.TradeTypes, "Id", "Name");
            return View();
        }

        // POST: Strategies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Created,Name,Description,PriceStart,PriceStopLoss,SymbolId,TradeTypeId")] Strategy strategy)
        {
            if (ModelState.IsValid)
            {
                _context.Add(strategy);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["SymbolId"] = new SelectList(_context.Symbols, "Id", "Name", strategy.SymbolId);
            ViewData["TradeTypeId"] = new SelectList(_context.TradeTypes, "Id", "Name", strategy.TradeTypeId);
            return View(strategy);
        }

        // GET: Strategies/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strategy = await _context.Strategies.SingleOrDefaultAsync(m => m.Id == id);
            if (strategy == null)
            {
                return NotFound();
            }
            ViewData["SymbolId"] = new SelectList(_context.Symbols, "Id", "Name", strategy.SymbolId);
            ViewData["TradeTypeId"] = new SelectList(_context.TradeTypes, "Id", "Name", strategy.TradeTypeId);
            return View(strategy);
        }

        // POST: Strategies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Created,Name,Description,PriceStart,PriceStopLoss,SymbolId,TradeTypeId")] Strategy strategy)
        {
            if (id != strategy.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strategy);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrategyExists(strategy.Id))
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
            ViewData["SymbolId"] = new SelectList(_context.Symbols, "Id", "Name", strategy.SymbolId);
            ViewData["TradeTypeId"] = new SelectList(_context.TradeTypes, "Id", "Name", strategy.TradeTypeId);
            return View(strategy);
        }

        // GET: Strategies/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strategy = await _context.Strategies
                .Include(s => s.Symbol)
                .Include(s => s.TradeType)
                .SingleOrDefaultAsync(m => m.Id == id);
            if (strategy == null)
            {
                return NotFound();
            }

            return View(strategy);
        }

        // POST: Strategies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var strategy = await _context.Strategies.SingleOrDefaultAsync(m => m.Id == id);
            _context.Strategies.Remove(strategy);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StrategyExists(int id)
        {
            return _context.Strategies.Any(e => e.Id == id);
        }
    }
}
