using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace oauth.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        [Required(AllowEmptyStrings=true)]
        public string GivenName{get;set;}

        [Required(AllowEmptyStrings=true)]
        public string LastName{get;set;}

        [Required(AllowEmptyStrings=true)]
        public string CompanyName{get;set;}
    }
}
