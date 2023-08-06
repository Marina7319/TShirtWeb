using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using T_shirt.ShoppingCart.Api.Models.Details;

namespace T_shirt.ShoppingCart.Api.Models.Data
{
    public class CartDetailsDto
    {
        [Key]

        public int CartDetailsId { get; set; }

        public int CartHeaderId { get; set; }

        [ForeignKey("CartHeaderId")]

        public CartHeaderDto? CartHeader { get; set; }

        public int ProductId { get; set; }

        public Product? Product { get; set; }

        public int Count { get; set; }
    }
}
