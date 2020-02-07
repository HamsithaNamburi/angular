using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using validationsonmvc.Models;
namespace validationsonmvc.Controllers
{
    public class ValidateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(login item)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
           //model state validates model
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee items)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }else
            //model state validates model
            
            return View();
        }
        
        
        //public IActionResult show()
        //{
        //    return View();
        //}
        //public IActionResult show1()
        //{
        //    return View();
        //}
    }
}