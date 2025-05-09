using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorProdutosApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Produto> Produtos { get; set; }

        public void OnGet()
        {
            Produtos = new List<Produto>
            {
                new Produto { Nome = "Teclado Epomaker Rt80", Preco = 500.00M },
                new Produto { Nome = "Mouse Delux M900 Pro", Preco = 187.97M },
                new Produto { Nome = "Monitor LED 27 LG Ultragear 180hz \"", Preco = 989.00M }
            };
        }

        public class Produto
        {
            public string Nome { get; set; }
            public decimal Preco { get; set; }
        }
    }
}
