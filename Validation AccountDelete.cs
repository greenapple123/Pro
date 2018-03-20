using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Retail_Bankingteam03.Models
{
    public class Validation_AccountDelete
    {
        [Required(ErrorMessage = "Account ID is required!")]
        public long AccountID_3 { get; set; }
        [Required(ErrorMessage = "Customer ID is required!")]
        public Nullable<long> CustomerID_3 { get; set; }
        [Required(ErrorMessage = "Please select one!")]
        public string AccountType_3 { get; set; }
        public Nullable<long> Balance_3 { get; set; }
        public string Status_3 { get; set; }
        public string Message_3 { get; set; }
        public Nullable<System.DateTime> LastUpdated_3 { get; set; }
    }
}
