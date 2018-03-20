using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Retail_Bankingteam03.Models
{
    public class Validation_update
    {
        public long CustomerID_3 { get; set; }
        public Nullable<long> CustomerSSID_3 { get; set; }
        public string OldCustomerName_3 { get; set; }
        [Required(ErrorMessage = "Customer Name is required!")]
        public string NewCustomerName_3 { get; set; }
        public Nullable<int> OldAge_3 { get; set; }
        [Required(ErrorMessage = "Customer Age is required!")]
        public Nullable<int> NewAge_3 { get; set; }
        public string OldCustomerAddress_3 { get; set; }
        [Required(ErrorMessage = "Customer Address is required!")]
        public string NewCustomerAddress_3 { get; set; }
        public string City_3 { get; set; }
        public string Status_3 { get; set; }
        public string Message_3 { get; set; }
        public Nullable<System.DateTime> LastUpdated_3 { get; set; }
    }
}
