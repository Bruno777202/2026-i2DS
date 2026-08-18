using Microsoft.VisualBasic;

internal class Program
{
    public class Produto
    {
        public double Id {get; set;}
        public string? Nome {get; set;}
        public int Preco {get; set;}
    }
    private static void Main(string[] args)
    {
        List<Produto> listaprodutos = new List<Produto>();
        Produto produto1 = new Produto{Id = 1, Nome = "Celular", Preco = 1500}; 
        Produto produto2 = new Produto{Id = 2, Nome = "mouse", Preco = 30};
        Produto produto3 = new Produto{Id = 3, Nome = "teclado", Preco = 500}; 
        Produto produto4 = new Produto{Id = 4, Nome = "munitor", Preco = 2600}; 

        foreach(var Produto in listaprodutos )
        {
           
        }

    }
}