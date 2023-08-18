using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Data.Data;
using T_shirt.Data.Repository.IRepository;
using T_shirt.Models.Models;

namespace T_shirt.Data.Repository
{
    public class ProductImageRepository : Repository<ProductImage>, IProductImageRepository
    {
        private TshirtStoreDbContext _db;
        public ProductImageRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ProductImage obj)
        {
            _db.ProductImages.Update(obj);
        }
    }
}
