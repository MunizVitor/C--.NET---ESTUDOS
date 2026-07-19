using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCsharp.Domain.UserDomain.UserModel
{
    [Table("users")]
    public class User : AbstractModel
    {
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;

        public int Idade { get; set; } = 0;
        public string Password { get; set; } = string.Empty;

        public User() { }

        public User(string nome, string email, string cpf, int idade, string password)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Email = email;
            Cpf = cpf;
            Idade = idade;
            Password = password;
            CreateProduct = DateTime.Now;
            IsActive = true;
        }

        public void InativarUser()
        {
            if (IsActive)
            {
                IsActive = false;
            }
        }
    }
}
