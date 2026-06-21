using WebApiCsharp.Model.User;

namespace WebApiCsharp.Infraestrutura.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(User userModel)
        {
            _context.User.Add(userModel);
            _context.SaveChanges();
        }

        public List<User> Get()
        {
            return _context.User.ToList();
        }

        public User GetById(int id)
        {
            return _context.User.Find(id);
        }
    }
}
