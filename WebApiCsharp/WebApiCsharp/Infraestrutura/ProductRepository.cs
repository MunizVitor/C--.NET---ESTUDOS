using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura
{
    public class ProductRepository : IProductRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Product product)
        {
            
            _context.Product.Add(product);
            _context.SaveChanges();
        }

        public List<Product> Get()
        {
            return _context.Product.ToList();
        }

        public Product? GetId(int id)
        {
            return _context.Product.Find(id);
        }
    }
}
