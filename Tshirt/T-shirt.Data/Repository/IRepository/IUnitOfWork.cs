namespace T_shirt.Data.Repository.IRepository
{

    using T_shirt.Data.Repository.IRepository;

    public interface IUnitOfWork //: IDisposable
    {

        ICategoryRepository Category { get; }

        ITshirtTypeRepository TshirtType { get; }

        // ISP_Call SP_Call { get; }

        IProductRepository Product { get; }

        IShoppingCartRepository ShoppingCart { get; }

        IApplicationUserRepository ApplicationUser { get; }

        IOrderDetailRepository OrderDetail { get; }

        IOrderHeaderRepository OrderHeader { get; }

        void Save();

    }
}
