using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Retail_Bankingteam03.Models
{
    public class Loginvalidations
    {

    }
    [MetadataType(typeof(Login))]
    
     public partial class LoginDetails_3
    {
      
    }
    public class Login
    {
        public int LoginID_3 { get; set; }
        [Required (ErrorMessage ="!  User Id cannot be blank  !")]
        [validations_uname]
        public string UserName_3 { get; set; }
        [Required(ErrorMessage ="!  Required Password  !")]
        [validations_password]
        public string UserPassword_3 { get; set; }
        public string UserRole_3 { get; set; }
        public Nullable<System.DateTime> LoginTime_3 { get; set; }
    }
}
