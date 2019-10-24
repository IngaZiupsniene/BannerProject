using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GDPRApp.Utillity
{
    public class FieldValidate : ValidationAttribute
    {
        private string valField;
        public FieldValidate(string value)
        {
            valField = value;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)

        {

            if (value != null)
            {
                if (value.Equals(valField))
                {   
                    return new ValidationResult("Select from the list");
                }
            }

            return ValidationResult.Success;

        }

    }
}
