using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura.Repository
{
    public interface IProductRepository
    {
        void Add(Product  product);
        List<Product> Get();
    }
}
