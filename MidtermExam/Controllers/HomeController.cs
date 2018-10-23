using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MidtermExam.Models;


namespace MidtermExam.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() { 
        {
            Product[] array =
            {
                new Product {ItemID= "1663" , Description = "antistatic Wipes" , UnitsOnHand = "30" , Cost = "$0.15" , SellingPrice = "$0.25" }
            };
                return View(array);
        }
        
        }
    }
}
