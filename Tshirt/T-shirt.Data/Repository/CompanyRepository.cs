using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using T_shirt.Data.Repository.IRepository;
using T_shirt.Data.Data;
using T_shirt.Models.Models;

namespace T_shirt.Data.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private TshirtStoreDbContext _db;
        public CompanyRepository(TshirtStoreDbContext db) : base(db)
        {
            _db = db;
        }



        public void Update(Company company)
        {
            _db.Update(company);
        }
    }
}
