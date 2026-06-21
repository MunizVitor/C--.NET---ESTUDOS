using Microsoft.EntityFrameworkCore;
using WebApiCsharp.Model;
using WebApiCsharp.Model.User;

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
