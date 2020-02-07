using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using Employee.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Employee.Controllers
{
    public class EmployeeController : Controller
    {
        
     private readonly   IEmployeeRepository  employeeRepository;
        public EmployeeController(IEmployeeRepository emrepositry)
        {
            employeeRepository = emrepositry;
        }
        public IActionResult search(int? id)
        {
            int   ID = (int)((id == null) ? 1 : id);
       MyEmployee emp= employeeRepository.GetEmployee(ID);
            //if (emp != null)
            //{
            //    return Content(emp.id + "\n" + emp.name + "\n" + emp.Email + "\n" + emp.Dept);
            //}
            //return Content("employee does not exists");
            //ViewData["id"] = emp.id;
            //ViewData["name"] = emp.name;
            //ViewData["Email"] = emp.Email;
            //ViewData["dept"] = emp.Dept;
            //ViewBag.id = emp.id;
            //ViewBag.name = emp.name;
            //ViewBag.Email = emp.Email;
            //ViewBag.dept = emp.Dept;
           // ViewData["employee"] = emp;
           return View(emp);

        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            List<MyEmployee> eelist = employeeRepository.display();
            return View(eelist);
        }
        //public JsonResult ContactUs()
        //{
        //    return Json("{id:1;name:hello}");
        //}

        public IActionResult AboutEmployee()
        {
            MyEmployee emp = employeeRepository.GetEmployee(2);
            //V ewBag.Projectname = "Quantizization";
            Employemodelview ep = new Employemodelview();
            ep.employee = emp;
            ep.projectname = "bookhive";
            return View(ep);
        }
        public IActionResult GetAllEmployee()
        {
            List<MyEmployee> ell = (employeeRepository.display()).Where(e=>e.Dept==Dept.It).ToList();
            //  return View("~/Views/Employee/Index.cshtml",ell);//absolute path
            return View("Index", ell);//relative path
        }
        [HttpGet]
        public IActionResult create()
        {
            //MyEmployee emp = employeeRepository.GetEmployee(2);
            //return View(emp);
            return View();
        }
        [HttpPost]
        public IActionResult create(MyEmployee employee)
        {
            if (ModelState.IsValid)
            {
                employeeRepository.Addemployee(employee);
                return RedirectToAction("Index");
            }
            //}else
            //return View("Fail");
            return View();

        }
        public IActionResult Fail()
        {
            return View();
        }
            public IActionResult success()
        {
           
            return View();
            
        }
        public IActionResult list()
        {
            List<MyEmployee> elist = employeeRepository.display();
            return View(elist);
        }
        [HttpGet]
        public IActionResult register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult register(MyEmployee employee)
        {
            bool res = employeeRepository.Addemployee(employee);
            return RedirectToAction("Index");
            
        }
        public bool IsExists(string email)
        {
            var result = (employeeRepository.display()).Find(r => r.Email == email);
            if (result == null)
                return true;
            else return false;
        }
        [AcceptVerbs("Get","Post")]

        public IActionResult IsEmailExist(string email)
        {

            return IsExists(email)?Json(true):Json("email exist");
        }

        public IActionResult _myPartial()
        {
            return View();
        }
        
       
    }
}
