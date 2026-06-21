using Microsoft.AspNetCore.Mvc;
using WebApiCsharp.Infraestrutura.UserRepository;
using WebApiCsharp.Model.User;
using WebApiCsharp.ViewModel;

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

        [HttpPost]
        public IActionResult Add(UserViewModel data)
        {
            var user = new User(data.Nome, data.Email, data.Cpf);
            _repository.Add(user);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _repository.GetById(id);
            return Ok(user);
        }

        [HttpGet]
        public IActionResult Get()
        {
            var users = _repository.Get();
            return Ok(users);
        }
    }
}