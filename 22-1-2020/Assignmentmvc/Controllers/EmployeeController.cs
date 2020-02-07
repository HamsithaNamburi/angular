using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Assignmentmvc.Models;
using Assignmentmvc.Repositeries;


namespace Assignmentmvc.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult create()
        {
            ViewData["Desig"] = new SelectList(new List<string>() { "PAT", "PA", "SA", "Manger" });
            ViewData["proname"] = new SelectList(new List<string>() { "ABC", "A1", "A2", "A3" });
            return View();
        }
        [HttpPost]
        public IActionResult create(Employee empl)
        {
            EmployeeRepository elist = new EmployeeRepository();
            elist.add(empl);
            return View("Login");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string Eid,string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee employee = repository.validate( Eid,pwd);
            if (employee != null)
            {
                return RedirectToAction("Details", employee);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        
        public IActionResult Details(Employee empl)
        {
            return View(empl);
        }
        [HttpPost]
        public IActionResult Logout()
        {
            return View();
        }
    }
}