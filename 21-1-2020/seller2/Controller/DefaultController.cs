using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using seller2.Model;

namespace seller2.Controllers
{
    public class DefaultController : Controller
    {
      private readonly  ISellerRepository  SellerRepository;
        public DefaultController(ISellerRepository sellrepositary)
        {
            SellerRepository = sellrepositary;

        }
        public IActionResult  Search(int? id)
        {
            int ID = (int)((id == null) ? 1 : id);
            myseller sell = SellerRepository.GetMyseller(ID);
            //return sell.s_id + "\n" + sell.username + "\n" + sell.password + "\n" + sell.companyname +
            //    sell.GSTIN + "\n" + sell.website + "\n" + sell.Email + "\n" + sell.c_no;
            return View(sell);

        }
        public IActionResult Index()
        {
            List<myseller> elist = SellerRepository.display();
            return View(elist);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
   
        public IActionResult GetAllSeller()
        {
            List<myseller> sellist = (SellerRepository.display()).Where(e => e.username == "jhon").ToList();
            return View(sellist);
        }

        }
    }
