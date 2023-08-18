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
    public class ShoppingCartRepository : Repository<ShoppingCart>, IShoppingCartRepository
    {
        private TshirtStoreDbContext _db;
        public ShoppingCartRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(ShoppingCart obj)
        {
            _db.ShoppingCarts.Update(obj);
        }
    }
}
