using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T_shirt.Models.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
            .Where(p => p.Product.Id == product.Id)
            .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public void RemoveLine(Product product) =>
Lines.RemoveAll(l => l.Product.Id == product.Id);
        public decimal ComputeTotalValue() =>
        (decimal)Lines.Sum(e => e.Product.ListPrice * e.Quantity);
        public class CartLine
        {
            public int CartLineID { get; set; }
            public Product Product { get; set; } = new();
            public int Quantity { get; set; }
        }
    }
}
