using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PC4.Models;

namespace PC4.Controllers
{
    public class FailsController : Controller
    
    {
        private readonly FailContext _context;
        public FailsController(FailContext context){
           _context = context;
       }  
      [Authorize]
          public IActionResult Registro(Fails f){
           if(ModelState.IsValid){
               _context.Fails.Add(f);
               _context.SaveChanges();

               return RedirectToAction("Index", "Home");
           } else{
               return View(f);
           }
       }
       public IActionResult comentarios() {

           return View();
       }
       

    }
}