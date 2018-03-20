using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;

namespace Retail_Bankingteam03.Models
{
    public class validations_password: ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                string s = value.ToString();
                Regex r = new Regex("(?![.\n])(?=.*[!@#$%^&*()_+])(?=.*[0-9])(?=.*[A-Z])(?=.*[a-z]).*$");
                if (s.Length < 10)
                    return new ValidationResult("Username should be minimum 10 characters");

                else if (r.IsMatch(s))
                    return ValidationResult.Success;
                else
                    return new ValidationResult("Password should contain atleast one Uppercase,one lower case, one Special Character,one nuber");
            }
            else
                return new ValidationResult("Only Alpha Numeric values are allowed");
        }
    }
}
