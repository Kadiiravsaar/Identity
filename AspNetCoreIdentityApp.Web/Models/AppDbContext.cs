using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AspNetCoreIdentityApp.Web.Models
{
    public class AppDbContext : IdentityDbContext<AppUser,AppRole,string> // string ilgili kullanıcılar için random quid üreticek
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) // connection stringi program.cs de tutmak için
        {
            
        }
    }
}
