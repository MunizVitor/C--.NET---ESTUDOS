using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura.Repository
{
    public interface IFuncionarioRepository
    {
        void Add(Funcionario  funcionario);
        List<Funcionario> Get();
    }
}
