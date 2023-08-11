using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T_shirt.Models.Models;

namespace T_shirtApp.Test.Models
{
    public interface IDataSource
    {
        IEnumerable<Product> Products { get; }
    }
}
