using WebApiCsharp.Domain.Dtos;
using WebApiCsharp.Domain.UserDomain.UserModel;

namespace WebApiCsharp.Infraestrutura.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(User userModel)
        {
            _context.User.Add(userModel);
            _context.SaveChanges();
        }

        public List<UserDTO> Get()
        {
            return _context.User.Select(b => new UserDTO()
            {
                id = b.id,
                nome = b.nome,
                email = b.email,
                cpf = b.cpf
            }).ToList();
        }

        public User GetById(int id)
        {
            return _context.User.Find(id);
        }
    }
}
