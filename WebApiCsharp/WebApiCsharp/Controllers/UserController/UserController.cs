using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using WebApiCsharp.Aplication.ViewModel.UserView;
using WebApiCsharp.Domain.UserDomain.UserModel;
using WebApiCsharp.Infraestrutura.Repositories.UserRepository;

namespace WebApiCsharp.Controllers.UserController
{
    [ApiController]
    [Route("api/v1/users")]
    public class UserController : Controller
    {
        private readonly IUserRepository _repository;

        public UserController(IUserRepository userRepository)
        {
            _repository = userRepository ?? throw new ArgumentNullException();
        }

        [Authorize]
        [HttpPost]
        public IActionResult Add(UserViewModel data)
        {
            var user = new User(data.Nome, data.Email, data.Cpf, data.Idade, data.Password);
            _repository.Add(user);
            return Ok();
        }

        [Authorize]
        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _repository.GetById(id);
            return Ok(user);
        }

        [Authorize]
        [HttpGet]
        public IActionResult Get()
        {
            var users = _repository.Get();
            return Ok(users);
        }
    }
}