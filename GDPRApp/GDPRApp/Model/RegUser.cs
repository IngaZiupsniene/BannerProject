using GDPRApp.Utillity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDPRApp.Model
{
    public class RegUser
    {
        [Required(ErrorMessage="First Name is required")]
        [StringLength(255, ErrorMessage = "Must be between 3 and 255 characters", MinimumLength = 3)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string LastName { get; set; }      
        [FieldValidate("*Company Size")]
        public string CompanySize { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string Email { get; set; }       
        [FieldValidate("*Company Type")]
        public string CompanyType { get; set; }        
        [FieldValidate("*Country")]
        public string Country { get; set; }
        [Required(ErrorMessage = "Company is required")]       
        public string Company { get; set; }

        public string Message { get; set; }
    }
}
