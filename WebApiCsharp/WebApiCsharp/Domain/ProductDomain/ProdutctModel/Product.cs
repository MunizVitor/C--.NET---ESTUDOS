using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace WebApiCsharp.Domain.ProductDomain.ProdutctModel
{
    [Table("products")]
    public class Product
    {
        [Key]
        public int id { get; set; }
        
        public string nome { get; set; } = string.Empty;
        public int quantidade { get; set; } = 0;
        public string? foto { get; set; } = string.Empty;

        public Product() { }
        public Product(string nome, int quantidade, string foto) {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.quantidade = quantidade;
            this.foto = foto;
        }
    }
}
