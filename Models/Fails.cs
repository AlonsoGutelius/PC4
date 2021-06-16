using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PC4.Models
{
    public class Fails
    {
        public int Id {get;set; }
        [Required]
        public string titulo {get;set;}
        [Required]
        public string foto {get;set; }
        public DateTime FechaRegistro{get;set; }
        public string comentario {get;set;}

        
        

         public Fails(){
            FechaRegistro=DateTime.Now;
            

        }

        
    }
}