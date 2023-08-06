using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace T_shirt.ShoppingCart.Api.Models.Data
{
    public class CartHeaderDto
    {

        public int CartHeaderId { get; set; }

        public string? UserId { get; set; }

        public double CartTotal { get; set; }

    }
}
