using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserRegistrationPortal.Models;  // add this

namespace UserRegistrationPortal.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>  // <-- update here
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
