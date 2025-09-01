using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace BlazorWebAppWithBrandingAuth.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {

        [Required]
        public string? FirstName { get; set; }
        [Required]
        public string? LastName { get; set; }
    }

}
