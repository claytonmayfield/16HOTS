using System.ComponentModel.DataAnnotations;

namespace SalesOrdersApp.Models
{
    public class Category
    {
        public int CategoryID { get; set; }

        [Required]
        public string? CategoryName { get; set; }
    }
}
