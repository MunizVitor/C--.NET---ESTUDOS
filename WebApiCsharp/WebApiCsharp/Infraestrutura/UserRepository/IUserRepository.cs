using WebApiCsharp.Model.User;

namespace WebApiCsharp.Infraestrutura.UserRepository
{
    public interface IUserRepository
    {
        void Add(User userModel);
        User GetById(int id);
        List<User> Get();
    }
}
