using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.NetworkInformation;
using WebApiCsharp.Infraestrutura.RepositoryProduct;
using WebApiCsharp.Model;
using WebApiCsharp.ViewModel.ProductView;

namespace WebApiCsharp.Controllers.ProductController
{
    [ApiController]
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _repository;
        private readonly ILogger<ProductController> _logger;

        public ProductController(IProductRepository repository, ILogger<ProductController> logger)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [Authorize]
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

        [Authorize]
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

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var products = _repository.Get();
            return Ok(products);
        }

        [HttpGet]
        [Route("/paginacao")]
        public IActionResult GetPaginacao(string pageNumber, string pageQuality)
        {
            int quality = int.Parse(pageQuality);
            int number = int.Parse(pageNumber);

            _logger.Log(LogLevel.Error, "TEVE UM ERRO");
            var products = _repository.GetPaginacao(number, quality);
            _logger.LogInformation("TESTE INFORMAÇÃO");

            return Ok(products);
        }
    }
}
