using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BillAPIProject.Models;

namespace BillAPIProject.Controllers
{
    public class Table2Controller : Controller
    {
        private readonly BillDataContext _context;

        public Table2Controller(BillDataContext context)
        {
            _context = context;
        }

        // GET: Table2
        public async Task<IActionResult> Index()
        {
            return View(await _context.Table2.ToListAsync());
        }

        // GET: Table2/Details/5
        public async Task<IActionResult> Details(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table2 = await _context.Table2
                .FirstOrDefaultAsync(m => m.Row == id);
            if (table2 == null)
            {
                return NotFound();
            }

            return View(table2);
        }

        // GET: Table2/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnerId,PartnerName,PartnerBillableAccountId,CustomerCompanyName,MpnId,InvoiceNumber,ChargeStartDate,ChargeEndDate,SubscriptionId,SubscriptionName,SubscriptionDescription,OrderId,ServiceName,ServiceType,ResourceGuid,ResourceName,Region,Sku,DetailLineItemId,ConsumedQuantity,IncludedQuantity,OverageQuantity,ListPrice,PretaxCharges,TaxAmount,PostTaxTotal,Currency,PretaxEffectiveRate,PostTaxEffectiveRate,ChargeType,CustomerId,DomainName,BillingCycleType,Unit,Row")] Table2 table2)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table2);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table2);
        }

        // GET: Table2/Edit/5
        public async Task<IActionResult> Edit(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table2 = await _context.Table2.FindAsync(id);
            if (table2 == null)
            {
                return NotFound();
            }
            return View(table2);
        }

        // POST: Table2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(decimal id, [Bind("PartnerId,PartnerName,PartnerBillableAccountId,CustomerCompanyName,MpnId,InvoiceNumber,ChargeStartDate,ChargeEndDate,SubscriptionId,SubscriptionName,SubscriptionDescription,OrderId,ServiceName,ServiceType,ResourceGuid,ResourceName,Region,Sku,DetailLineItemId,ConsumedQuantity,IncludedQuantity,OverageQuantity,ListPrice,PretaxCharges,TaxAmount,PostTaxTotal,Currency,PretaxEffectiveRate,PostTaxEffectiveRate,ChargeType,CustomerId,DomainName,BillingCycleType,Unit,Row")] Table2 table2)
        {
            if (id != table2.Row)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table2);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table2Exists(table2.Row))
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
            return View(table2);
        }

        // GET: Table2/Delete/5
        public async Task<IActionResult> Delete(decimal? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table2 = await _context.Table2
                .FirstOrDefaultAsync(m => m.Row == id);
            if (table2 == null)
            {
                return NotFound();
            }

            return View(table2);
        }

        // POST: Table2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(decimal id)
        {
            var table2 = await _context.Table2.FindAsync(id);
            _context.Table2.Remove(table2);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table2Exists(decimal id)
        {
            return _context.Table2.Any(e => e.Row == id);
        }
    }
}
