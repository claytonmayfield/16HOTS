using System.ComponentModel.DataAnnotations;

namespace SalesOrdersApp.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        [Required(ErrorMessage = "Customer First Name Required!")]
        public string? CustomerFirstName { get; set; }

        [Required(ErrorMessage = "Customer Last Name Required!")]
        public string? CustomerLastName { get; set; }

        [Required(ErrorMessage = "Customer Street Address Required!")]
        public string? CustomerAddress { get; set; }

        [Required(ErrorMessage = "Customer City Required!")]
        public string? CustomerCity { get; set; }

        [Required(ErrorMessage = "Customer State Required!")]
        public string? CustomerState { get; set; }

        [Required(ErrorMessage = "Customer Zip Code Required!")]
        public string? CustomerZipCode { get; set; }

        public string? CustomerPhone { get; set; }
        public string FullName => CustomerFirstName + " " + CustomerLastName;   // read-only property

    }
}
