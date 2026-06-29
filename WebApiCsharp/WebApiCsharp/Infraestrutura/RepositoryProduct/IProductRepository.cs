using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura.RepositoryProduct
{
    public interface IProductRepository
    {
        void Add(Product  product);
        List<Product> Get();
        List<Product> GetPaginacao(int pageNumber, int pageQuality);
        Product? GetId(int id);
    }
}
