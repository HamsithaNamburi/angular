using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employee.Models;
using EmployeeManagment.Data;

namespace EmployeeManagment.Controllers
{
    public class MyEmployeesController : Controller
    {
        private readonly EmployeeManagmentContext _context;

        public MyEmployeesController(EmployeeManagmentContext context)
        {
            _context = context;
        }

        // GET: MyEmployees
        //public async Task<IActionResult> Index()
        //{
        //    return View(await _context.MyEmployee.ToListAsync());
        //}
        public IActionResult Index()
        {
            return View(_context.MyEmployee.ToList());
        }
        // GET: MyEmployees/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myEmployee = await _context.MyEmployee
                .FirstOrDefaultAsync(m => m.id == id);
            if (myEmployee == null)
            {
                return NotFound();
            }

            return View(myEmployee);
        }

        // GET: MyEmployees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MyEmployees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,Email,Dept")] MyEmployee myEmployee)
        {
            if (ModelState.IsValid)
            {
                _context.Add(myEmployee);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(myEmployee);
        }

        // GET: MyEmployees/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myEmployee = await _context.MyEmployee.FindAsync(id);
            if (myEmployee == null)
            {
                return NotFound();
            }
            return View(myEmployee);
        }

        // POST: MyEmployees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id,name,Email,Dept")] MyEmployee myEmployee)
        {
            if (id != myEmployee.id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(myEmployee);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MyEmployeeExists(myEmployee.id))
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
            return View(myEmployee);
        }

        // GET: MyEmployees/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var myEmployee = await _context.MyEmployee
                .FirstOrDefaultAsync(m => m.id == id);
            if (myEmployee == null)
            {
                return NotFound();
            }

            return View(myEmployee);
        }

        // POST: MyEmployees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var myEmployee = await _context.MyEmployee.FindAsync(id);
            _context.MyEmployee.Remove(myEmployee);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MyEmployeeExists(int id)
        {
            return _context.MyEmployee.Any(e => e.id == id);
        }
    }
}
