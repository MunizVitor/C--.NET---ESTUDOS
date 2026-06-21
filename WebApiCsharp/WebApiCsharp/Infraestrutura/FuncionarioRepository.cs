using WebApiCsharp.Infraestrutura.Repository;
using WebApiCsharp.Model;

namespace WebApiCsharp.Infraestrutura
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Funcionario funcionario)
        {
            
            _context.Funcionario.Add(funcionario);
            _context.SaveChanges();
        }

        public List<Funcionario> Get()
        {
            return _context.Funcionario.ToList();
        }
    }
}
