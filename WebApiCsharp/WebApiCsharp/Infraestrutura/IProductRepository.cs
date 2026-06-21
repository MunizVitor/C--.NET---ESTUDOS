using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura
{
    public interface IProductRepository
    {
        void Add(Product  product);
        List<Product> Get();
        Product? GetId(int id);
    }
}
