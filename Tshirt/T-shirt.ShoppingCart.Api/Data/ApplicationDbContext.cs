namespace T_shirt.ShoppingCart.Api.Data
{

    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using T_shirt.Models.Models;
    using T_shirt.ShoppingCart.Api.Models;

    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public DbSet<Category> Categories { get; set; }
        public DbSet<CartHeader> CartHeaders { get; set; }
        public DbSet<CartDetails> CartDetails { get; set; }
       // public DbSet<Product> Products { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }

      
        }
    }
}
