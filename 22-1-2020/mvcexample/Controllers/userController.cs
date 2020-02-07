using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mvcexample.Repositories;
using mvcexample.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace mvcexample.Controllers
{
    public class userController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult create()

        {
            //ViewData["country"] = new SelectList(new List<string>(){"", "India", "China", "Us", "Uk" });
           
            return View();
        }
        public IActionResult create(user item)
        {
            userrepository urep = new userrepository();
                    urep.Add(item);
            if (ModelState.IsValid)
            {
                return RedirectToAction("login");
            }
            return View();
        }
            
        public IActionResult login()
        {
            return View();
        }
        [HttpPost]

        public IActionResult login(string uname,string pwd)
        {
            userrepository repository = new userrepository();
            user user = repository.validate(uname,pwd);
            if (user!= null)
            {
                return RedirectToAction("Details",user);
            }
            else
            {
                ViewData["err"] = "Invalid Credentials";
                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name")]user item)
        {
            return View(item);
        }
    }
}