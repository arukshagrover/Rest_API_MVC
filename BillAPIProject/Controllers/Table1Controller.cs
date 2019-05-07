using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BillAPIProject.Models;
using System.Collections;

namespace BillAPIProject.Controllers
{
    public class Table1Controller : Controller
    {
        private readonly BillDataContext _context;

        public Table1Controller(BillDataContext context)
        {
            _context = context;
        }

        // GET: Table1
        /* public async Task<IActionResult> Index()
         {
             return View(await _context.Table1.ToListAsync());
         }
         */

        public async Task<IActionResult> Index()
        {
            //var tab1=from m in _context.Table1 group m by new { m.CustomerName, m.SubscriptionName } into g orderby g.Key.CustomerName select new Table1  { CustomerName= g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName,UnitPrice=g.Sum(item=>item.UnitPrice)};

            //var tabtest = from m in _context.Table1 group m by new { m.CustomerName, m.SubscriptionName } into g orderby g.Key.CustomerName select new Table1 { CustomerName = g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName, UnitPrice = g.Sum(item => item.UnitPrice), };

            var tab3 = _context.Table1
                .GroupBy(x => new { x.CustomerName, x.SubscriptionName, x.UnitPrice })
                .Select(g => new { CustomerName = g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName, Price = g.Key.UnitPrice, Total = g.Count() });

            var tab2 = tab3.ToList();
            List<Result1> myList = new List<Result1>();
            var subsname = tab3.Select(x => x.SubscriptionName).ToList();
            var custname = tab3.Select(x => x.CustomerName).ToList();
            var ct1 = tab3.Select(x => x.Total).ToList();
            var price1 = tab3.Select(x => x.Price).ToList();
            Result1 ob = new Result1 { CustName = custname, SubsName = subsname, UnitP = price1, ct = ct1 };
            return Json(ob);







            // return View(l);


        }

        [HttpGet]
        //https://localhost:44399/table1/returndata?justdate=2019,01,19
        //https://localhost:44399/api/2019,01,19

        public JsonResult ReturnData(DateTime justdate)
        {
            //var tab1=from m in _context.Table1 group m by new { m.CustomerName, m.SubscriptionName } into g orderby g.Key.CustomerName select new Table1  { CustomerName= g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName,UnitPrice=g.Sum(item=>item.UnitPrice)};

            //var tabtest = from m in _context.Table1 group m by new { m.CustomerName, m.SubscriptionName } into g orderby g.Key.CustomerName select new Table1 { CustomerName = g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName, UnitPrice = g.Sum(item => item.UnitPrice), };
           // DateTime justDate = new DateTime(2019,1,19);
            var tab3 = _context.Table1.Where(y=>y.SubscriptionStartDate>=justdate)
                .GroupBy(x => new { x.CustomerName, x.SubscriptionName, x.UnitPrice })
                .Select(g => new { CustomerName = g.Key.CustomerName, SubscriptionName = g.Key.SubscriptionName, Price = g.Key.UnitPrice, Total = g.Count() });

            var tab2 = tab3.ToList();
            List<Result1> myList = new List<Result1>();
            var subsname = tab3.Select(x => x.SubscriptionName).ToList();
            var custname = tab3.Select(x => x.CustomerName).ToList();
            var ct1 = tab3.Select(x => x.Total).ToList();
            var price1 = tab3.Select(x => x.Price).ToList();
            Result1 ob = new Result1 { CustName = custname, SubsName = subsname, UnitP = price1, ct = ct1 };
         

            return Json(ob);
        }

        // GET: Table1/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1
                .FirstOrDefaultAsync(m => m.SubscriptionId == id);
            if (table1 == null)
            {
                return NotFound();
            }

            return View(table1);
        }

        // GET: Table1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PartnerId,CustomerId,CustomerName,MpnId,OrderId,SubscriptionId,SyndicationPartnerSubscriptionNumber,OfferId,DurableOfferId,OfferName,SubscriptionStartDate,SubscriptionEndDate,ChargeStartDate,ChargeEndDate,ChargeType,UnitPrice,Quantity,Amount,TotalOtherDiscount,Subtotal,Tax,TotalForCustomer,Currency,DomainName,SubscriptionName,SubscriptionDescription,BillingCycleType")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table1);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table1);
        }

        // GET: Table1/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1.FindAsync(id);
            if (table1 == null)
            {
                return NotFound();
            }
            return View(table1);
        }

        // POST: Table1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PartnerId,CustomerId,CustomerName,MpnId,OrderId,SubscriptionId,SyndicationPartnerSubscriptionNumber,OfferId,DurableOfferId,OfferName,SubscriptionStartDate,SubscriptionEndDate,ChargeStartDate,ChargeEndDate,ChargeType,UnitPrice,Quantity,Amount,TotalOtherDiscount,Subtotal,Tax,TotalForCustomer,Currency,DomainName,SubscriptionName,SubscriptionDescription,BillingCycleType")] Table1 table1)
        {
            if (id != table1.SubscriptionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table1);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table1Exists(table1.SubscriptionId))
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
            return View(table1);
        }

        // GET: Table1/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table1 = await _context.Table1
                .FirstOrDefaultAsync(m => m.SubscriptionId == id);
            if (table1 == null)
            {
                return NotFound();
            }

            return View(table1);
        }

        // POST: Table1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var table1 = await _context.Table1.FindAsync(id);
            _context.Table1.Remove(table1);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table1Exists(string id)
        {
            return _context.Table1.Any(e => e.SubscriptionId == id);
        }
    }
}
