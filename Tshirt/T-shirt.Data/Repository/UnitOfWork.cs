using T_shirt.Data.Data;
using T_shirt.Data.Repository.IRepository;

namespace T_shirt.Data.Repository
{


    public class UnitOfWork : IUnitOfWork
    {

        public ApplicationDbContext database;

        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }

        public IShoppingCartRepository ShoppingCart { get; private set; }


        public IOrderHeaderRepository OrderHeader { get; private set; }

        public IOrderDetailRepository OrderDetail { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {

            database = db;
            Category = new CategoryRepository(database);
            Product = new ProductRepository(database);
      

        }

        public void Save()
        {
            database.SaveChanges();
        }

    }
}
