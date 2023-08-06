namespace T_shirt.ShoppingCart.Api.Models.Data
{
    public class CartDto
    {

        public CartHeaderDto CartHeader {  get; set; }
        public IEnumerable<CartDetailsDto>? CartDetails { get; set; }
    }
}
