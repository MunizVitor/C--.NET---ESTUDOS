using WebApiCsharp.Domain.UserDomain.UserModel;

namespace WebApiCsharp.Infraestrutura.Repositories.UserRepository
{
    public interface IUserRepository
    {
        void Add(User userModel);
        User GetById(int id);
        List<User> Get();
    }
}
