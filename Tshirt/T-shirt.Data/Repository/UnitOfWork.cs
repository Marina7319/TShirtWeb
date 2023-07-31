namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Data.Data;

    public class UnitOfWork : IUnitOfWork
    {

        public ApplicationDbContext _db;

        public ICategoryRepository Category { get; private set; }

        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext db)
        {

            _db = db;
            Category = new CategoryRepository(_db);
            Product = new ProductRepository(_db);

        }

        public void Save()
        {
            _db.SaveChanges();
        }

    }
}
