using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Retail_Bankingteam03.Models
{
    public class Valdation_deletecust
    {
        [Required(ErrorMessage = "Customer_ID is required!")]
        public long CustomerID_3 { get; set; }
        public Nullable<long> CustomerSSID_3 { get; set; }
        public string CustomerName_3 { get; set; }
        public Nullable<int> Age_3 { get; set; }
        public string CustomerAddress_3 { get; set; }
        public string State_3 { get; set; }
        public string City_3 { get; set; }
        public string Status_3 { get; set; }
        public string Message_3 { get; set; }
        public Nullable<System.DateTime> LastUpdated_3 { get; set; }

    }
}
