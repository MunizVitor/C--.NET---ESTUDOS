using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura.RepositoryProduct
{
    public interface IProductRepository
    {
        void Add(Product  product);
        List<Product> Get();
        Product? GetId(int id);
    }
}
