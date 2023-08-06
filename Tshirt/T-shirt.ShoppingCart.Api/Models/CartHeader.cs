using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace T_shirt.ShoppingCart.Api.Models
{
    public class CartHeader
    {

        [Key]

        public int CartHeaderId { get; set; }

        public string? UserId { get; set; }

        [NotMapped]

        public double CartTotal { get; set; }


    }
}
