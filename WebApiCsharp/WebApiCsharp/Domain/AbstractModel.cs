using System;
using System.ComponentModel.DataAnnotations;

namespace WebApiCsharp.Domain
{
    public abstract class AbstractModel
    {
        [Key]
        public int Id { get; set; }

        public DateTime CreateProduct { get; set; } = DateTime.Now;

        public bool IsActive { get; set; } = true;

        public void InativarProduct()
        {
            if (IsActive)
            {
                IsActive = false;
            }
        }
    }
}
