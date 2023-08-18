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
    public class TshirtTypeRepository : Repository<TshirtType>, ITshirtTypeRepository
    {

        private readonly TshirtStoreDbContext database;

        public TshirtTypeRepository(TshirtStoreDbContext db) : base(db) //CategoryRepository
        {
            database = db;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(TshirtType obj) // Update
        {
            database.TshirtTypes.Update(obj);
        }

    }

}
