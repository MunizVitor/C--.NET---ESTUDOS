using Microsoft.AspNetCore.Mvc;
using WebApiCsharp.Infraestrutura;
using WebApiCsharp.Model;
using WebApiCsharp.ViewModel;

namespace WebApiCsharp.Controllers
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;

        public ProductController(IProductRepository productRepository)
        {
            _repository= productRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add([FromForm] ProductViewModel data)
        {
            var filePath = Path.Combine("Storage", data.Foto.FileName);
            using Stream fileStream = new FileStream(filePath, FileMode.Create);
            data.Foto.CopyTo(fileStream);

            var product = new Product(data.Nome, data.Quantidade, filePath);
            _repository.Add(product);
            return Ok();
        }

        [HttpGet]
        [Route("{id}/download")]
        public IActionResult DownloadFoto(int id)
        {
            var product = _repository.GetId(id);
            if (System.IO.File.Exists(product.foto))
            {
                var dataBytes = System.IO.File.ReadAllBytes(product.foto);
                return File(dataBytes, "image/png");
            }
            return NotFound("Arquivo não encontrado");
        }


        [HttpGet]
        public IActionResult Get()
        {
            var products = _repository.Get();
            return Ok(products);
        }
    }
}
