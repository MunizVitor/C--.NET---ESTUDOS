using Microsoft.EntityFrameworkCore;
using WebApiCsharp.Domain.ProductDomain.ProductModel;
using WebApiCsharp.Domain.UserDomain.UserModel;

namespace WebApiCsharp.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Product> Product { get; set; }
        public DbSet<User> User{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseNpgsql(
          "Server=localhost;" +
          "Port=5432;Database=webapi_Csharp;" +
          "User Id=postgres;" +
          "Password=admin;");
    }
}
