namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private TshirtStoreDbContext _db;
        public ShoppingCartRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ShoppingCart obj)
        {
            _db.Update(obj);
        }
    }
}
