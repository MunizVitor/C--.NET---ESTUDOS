using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCsharp.Model.User
{
    [Table("users")]
    public class User
    {
        [Key]
        public int id {  get; set; }
        public string nome {  get; set; } = string.Empty;
        public string email {  get; set; } = string.Empty;
        public string cpf {  get; set; } = string.Empty;

        public User () { }

        public User (string nome, string email, string cpf)
        {
            this.nome = nome;
            this.email= email;
            this.cpf = cpf;
        }
    }
}
