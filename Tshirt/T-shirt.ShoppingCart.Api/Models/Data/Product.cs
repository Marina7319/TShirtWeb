using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace T_shirt.ShoppingCart.Api.Models.Details
{
    public class Product
    {
        [Key]

        public int Id { get; set; }

        [Required]

        public string TshirtName { get; set; }

        public string Description { get; set; }

        [Required]

        public string Size { get; set; }

        [Required]

        public string Color { get; set; }

        [Required]
        [Display(Name = "List Price")]
        [Range(1, 98)]

        public double ListPrice { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [ValidateNever]

        public Category Category { get; set; }

        [ValidateNever]

        public string ImageUrl { get; set; }
    }
}
