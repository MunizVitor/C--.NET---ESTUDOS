using Microsoft.EntityFrameworkCore;
using WebApiCsharp.Domain.ProductDomain.ProductModel;
using WebApiCsharp.Domain.UserDomain.UserModel;

namespace WebApiCsharp.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User{ get; set; }

        public ConnectionContext(DbContextOptions<ConnectionContext> options) : base(options)
        {
            if (Database.GetPendingMigrations().Any())
                Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySQL(
                "Server=localhost;Port=3306;Database=webapi_csharp;User=root;Password=admin;"
            );
    }
}
