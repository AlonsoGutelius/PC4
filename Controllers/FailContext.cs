using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using PC4.Models;

namespace PC4.Controllers
{
    public class FailContext : IdentityDbContext
    {
      
        public DbSet<Fails> Fails {get;set; }
        
       
        public FailContext(DbContextOptions dco) : base(dco){

        }
    }
    
}