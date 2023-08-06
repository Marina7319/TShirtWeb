namespace T_shirt.ShoppingCart.Api.Models.Data
{
    public class Response
    {
        public object? Result {  get; set; }
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "";

    }
}
