namespace WebApiCsharp.ViewModel.ProductView
{
    public class ProductViewModel
    {
        public string Nome { get; set; }
        public int Quantidade{ get; set; }

        public IFormFile Foto { get; set; }
    }
}
