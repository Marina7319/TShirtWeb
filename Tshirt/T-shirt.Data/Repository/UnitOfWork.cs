namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    public class UnitOfWork : IUnitOfWork
    {

        public ICompanyRepository Company { get; set; }

        public IApplicationUserRepository ApplicationUser { get; set; }

        public IProductImageRepository ProductImage { get; set; }

        public TshirtStoreDbContext database;

        public ICategoryRepository Category { get; set; }

        public IProductRepository Product { get; set; }

        public IShoppingCartRepository ShoppingCart { get; set; }

        public IOrderHeaderRepository OrderHeader { get; set; }

        public IOrderDetailRepository OrderDetail { get; set; }

        public ITshirtTypeRepository TshirtType { get; set; }

        public UnitOfWork(TshirtStoreDbContext db)
        {

            database = db;
            Category = new CategoryRepository(database);
            Product = new ProductRepository(database);
            ProductImage = new ProductImageRepository(database);
            ApplicationUser = new ApplicationUserRepository(database);
            ShoppingCart = new ShoppingCartRepository(database);    
            Company = new CompanyRepository(database);
            OrderHeader = new OrderHeaderRepository(database);
            OrderDetail = new OrderDetailRepository(database);
            TshirtType = new TshirtTypeRepository(database);


        }

        public void Save()
        {
            database.SaveChanges();
        }

      // public void Dispose()
      // {
      //     throw new NotImplementedException();
      // }
    }
}
