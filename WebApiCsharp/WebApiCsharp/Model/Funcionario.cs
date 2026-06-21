using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebApiCsharp.Model
{
    [Table("funcionarios")]
    public class Funcionario
    {
        [Key]
        public int id { get; set; }
        
        public string nome { get; set; }
        public int idade { get; set; }
        public string foto { get; set; }

        public Funcionario() { }
        public Funcionario(string nome, int idade, string foto) {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.idade = idade;
            this.foto = foto;
        }
    }
}
