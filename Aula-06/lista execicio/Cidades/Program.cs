internal class Program
{

    public class Cidades
    {
        public string? Nome {get; set; }

    }
    private static void Main(string[] args)
    {
        Console.WriteLine("=== LISTA  DE CIDADES ====");

        List<Cidades> listaCidades = new List<Cidades>();

        Cidades cidades1 = new Cidades{Nome = "São Paulo"};
        Cidades cidades2 = new Cidades{Nome = "Rio de Janeiro"};
        Cidades cidades3 = new Cidades{Nome = "Salvador"};
        Cidades cidades4 = new Cidades{Nome = "Belo Horizonte"};
        Cidades cidades5 = new Cidades{Nome = "Curitiba"};


        foreach (var cidades in listaCidades )
        {
            Console.WriteLine($"{cidades.Nome}");
        }

    }
}