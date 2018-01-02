using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace oauth.Models.AccountViewModels
{
    public class ExternalLoginViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string GivenName { get; set; }
        
        [Required]
        public string LastName { get; set; }

        [Required]
        public string CompanyName { get; set; }

    }
}
