using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApiCsharp.Domain.ProductDomain.ProductModel
{
    [Table("products")]
    public class Product : AbstractModel
    {
        public string Nome { get; set; } = string.Empty;
        public int Quantidade { get; set; } = 0;
        public string? Foto { get; set; } = string.Empty;

        public Product() { }

        public Product(string nome, int quantidade, string foto)
        {
            Nome = nome ?? throw new ArgumentNullException(nameof(nome));
            Quantidade = quantidade;
            Foto = foto;
            CreateProduct = DateTime.Now;
            IsActive = true;
        }

        public void InativarProduct()
        {
            if (IsActive)
            {
                IsActive = false;
            }
        }
    }
}
