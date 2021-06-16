using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PC4.Models;

namespace PC4.Controllers
{
    public class HomeController : Controller
    {
      private readonly FailContext _context;

        public HomeController(FailContext context)
        {
           _context= context;
        }

        public IActionResult Index()
        {
             var  fails = _context.Fails.Where(x =>x.FechaRegistro.AddDays(10) > DateTime.Now).ToList();
            return View(fails);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
