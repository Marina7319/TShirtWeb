namespace T_shirt.Data.Repository
{

    using T_shirt.Data.Data;

    using T_shirt.Data.Repository.IRepository;

    using T_shirt.Models.Models;

    public class CategoryRepository : Repository<Category>, ICategoryRepository 
    {

        private readonly ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);
        }
    }
}
