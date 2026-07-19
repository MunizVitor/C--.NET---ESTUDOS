using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApiCsharp.Domain.ProductDomain.ProdutctModel;

namespace WebApiCsharp.Infraestrutura.Repositories.RepositoryProduct
{
    public interface IProductRepository
    {
        void Add(Product  product);
        List<Product> Get();
        List<Product> GetPaginacao(int pageNumber, int pageQuality);
        Product? GetId(int id);
    }
}
