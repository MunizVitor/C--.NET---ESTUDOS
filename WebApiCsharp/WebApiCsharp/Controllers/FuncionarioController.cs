using Microsoft.AspNetCore.Mvc;
using System.Data;
using WebApiCsharp.Infraestrutura.Repository;
using WebApiCsharp.Model;
using WebApiCsharp.ViewModel;

namespace WebApiCsharp.Controllers
{
    [ApiController]
    [Route("api/v1/funcionarios")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _repository;

        public FuncionarioController(IFuncionarioRepository funcinarioRepository)
        {
            _repository= funcinarioRepository ?? throw new ArgumentNullException();
        }

        [HttpPost]
        public IActionResult Add(FuncionariosViewModel data)
        {
            var funcionario = new Funcionario(data.Nome, data.Idade, null);
            _repository.Add(funcionario);
            return Ok();
        }

        [HttpGet]
        public IActionResult Get()
        {
            var funcionarios = _repository.Get();
            return Ok(funcionarios);
        }
    }
}
