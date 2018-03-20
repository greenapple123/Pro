using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Retail_Bankingteam03.Models
{
    public class Valdate_create_customer
    {
    }

    [MetadataType(typeof(create_customer))]
    public partial class CustomerDetails_3
    {

    }

    public class create_customer
    {
        public long CustomerID_3 { get; set; }

        [Validate_ssid]
        [Required(ErrorMessage = "Customer SSN ID is required!")]
        public Nullable<long> CustomerSSID_3 { get; set; }

        [Required(ErrorMessage = "Customer Name is required!")]
        public string CustomerName_3 { get; set; }
        [Required(ErrorMessage = "Age is required!")]
        public Nullable<int> Age_3 { get; set; }
        [Required(ErrorMessage = "Customer Address is required!")]
        public string CustomerAddress_3 { get; set; }
        [Required(ErrorMessage = "State is required!")]
        public string State_3 { get; set; }
        [Required(ErrorMessage = "City is required!")]
        public string City_3 { get; set; }       
        public string Status_3 { get; set; }
        public string Message_3 { get; set; }
        public Nullable<System.DateTime> LastUpdated_3 { get; set; }
    }
}
