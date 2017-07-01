using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CustomerWebApp.ViewModel
{
    /// <summary>
    /// We need this view model as if the CustomerModel edmx is updated, we may lose all validation and other attributes on the properties.
    /// </summary>
    public class CustomerViewModel
    {
        public CustomerViewModel()
        {
            FirstName = string.Empty;
            Address2 = string.Empty;
            County = string.Empty;
            EmailAddress = string.Empty;
        }

        public int CustomerID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string Lastname { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string Address1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string Address2 { get; set; }

        [Required]
        public string Town { get; set; }
        public string County { get; set; }

        [Required]
        [Display(Name = "Post Code")]
        public string Postcode { get; set; }

        [Range(18, 65)]
        public int Age { get; set; }

        [EmailAddress]
        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
    }
}