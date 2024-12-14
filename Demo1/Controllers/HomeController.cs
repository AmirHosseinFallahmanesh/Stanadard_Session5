using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Demo1.Models;

namespace Demo1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }

        public IActionResult Index3()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }


        public IActionResult Order()
        {
            OrderViewModel order = new OrderViewModel()
            {
                Name = "customer 1025",
                Lines = new List<OrderLine>()
                {
                       new OrderLine()
                    {
                        Price=1500,
                        ProductName="S24 ultra ",
                        Qunaity=1
                    },
                    new OrderLine()
                    {
                        Price=1000,
                        ProductName="Iphone 14",
                        Qunaity=1
                    },
                       new OrderLine()
                    {
                        Price=200,
                        ProductName="buds pro",
                        Qunaity=2
                    },
                }
            };
            return View(order);
        }

        public IActionResult TestView()
        {
            return View("/views/folder/file.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
