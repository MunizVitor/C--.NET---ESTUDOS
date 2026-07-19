using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCsharp.Domain.UserDomain.UserModel
{
    [Table("users")]
    public class User
    {
        [Key]
        public int id {  get; set; }
        public string nome {  get; set; } = string.Empty;
        public string email {  get; set; } = string.Empty;
        public string cpf {  get; set; } = string.Empty;

        public int idade { get; set; } = 0;
        public string password { get; set; } = string.Empty;

        public User () { }

        public User (string nome, string email, string cpf, int idade, string password)
        {
            this.nome = nome;
            this.email= email;
            this.cpf = cpf;
            this.idade = idade;
            this.password = password;
        }
    }
}
