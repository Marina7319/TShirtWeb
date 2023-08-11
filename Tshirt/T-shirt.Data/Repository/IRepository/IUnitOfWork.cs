namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Data.Repository.IRepository;

    public interface IUnitOfWork
    {

        ICategoryRepository Category { get; }

        IProductRepository Product { get; }

        IShoppingCartRepository ShoppingCart { get; }

      //  IApplicationUserRepository ApplicationUser { get; }

        IOrderDetailRepository OrderDetail { get; }

        IOrderHeaderRepository OrderHeader { get; }

        void Save();

    }
}
