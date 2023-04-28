using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesOrdersApp.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        [Required(ErrorMessage = "Product Name Required!")]
        public string? ProductName { get; set; }

        [Required(ErrorMessage = "Product Desc Short Required!")]
        public string? ProductDescShort { get; set; }

        [Required(ErrorMessage = "Product Desc Long Required!")]
        public string? ProductDescLong { get; set; }

        [Required(ErrorMessage = "Product Image Required!")]
        public string? ProductImage { get; set; }

        [Range(0, 100000)]
        [Column(TypeName = "decimal (9, 2)")]
        public decimal ProductPrice { get; set; }

        [Range(0, 100000)]
        public int ProductQty { get; set; }

        [Required(ErrorMessage = "Please enter a category.")]
        public int CategoryID { get; set; }
        public string? Slug => ProductName.Replace(' ', '-');

        [ValidateNever]
        public Category? Category { get; set; } = null;
    }
}
