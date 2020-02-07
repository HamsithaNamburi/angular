using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagment.Controllers
{
    public class Employee1Controller : Controller
    {
        // GET: Employee1
        public ActionResult Index()
        {
            return View();
        }

        // GET: Employee1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Employee1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Edit/5
        public ActionResult Edit(int id)
        {

            return View();
        }
        // POST: Employee1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}