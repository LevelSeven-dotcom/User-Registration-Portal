using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace UserRegistrationPortal.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Key]
        public int UserID { get; set; }  // extra UserID

        // UserName, Email, Password are already included in IdentityUser
        // No need to redefine them, unless you want customized behavior
    }
}
