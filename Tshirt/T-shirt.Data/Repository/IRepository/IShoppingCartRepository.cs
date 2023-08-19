namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Models.Models;

    public interface IShoppingCartRepository : IRepository<ShoppingCart>
    {
        void Update(ShoppingCart obj);
    }
}
