using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Retail_Bankingteam03.Models
{
    public class validations_uname: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string s = value.ToString();
                Regex r = new Regex("^[a-zA-Z0-9]*$");
                if (s.Length < 8)
                    return new ValidationResult("Username should be minimum 8 characters");

                else if (r.IsMatch(s))
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Only Alpha Numeric values are allowed");
            }
            else
                return new ValidationResult("Only Alpha Numeric values are allowed");
        }
    }
}
